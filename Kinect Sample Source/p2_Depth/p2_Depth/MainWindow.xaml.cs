using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Kinect;

namespace p2_Depth
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MapDepthToByte = 8000 / 256;          // 나중에

        private KinectSensor _sensor = null;
        private DepthFrameReader _depthFrameReader = null;
        private WriteableBitmap _bitmap;
        private FrameDescription _description = null;
        private ushort[] _buffer = null;
        private int _stride;

        public ImageSource ImageSource
        {
            get
            {
                return _bitmap;
            }
        }

        public MainWindow()
        {
            _sensor = KinectSensor.GetDefault();
            _depthFrameReader = _sensor.DepthFrameSource.OpenReader();
            _depthFrameReader.FrameArrived += _depthFrameReader_FrameArrived;

            _description = _sensor.DepthFrameSource.FrameDescription;
            _bitmap = new WriteableBitmap(_description.Width, _description.Height, 96.0, 96.0, PixelFormats.Gray16, null);
            _buffer = new ushort[_description.LengthInPixels];
            // 픽셀수 * 한픽셀에 몇바이트인지 그다음 stride는 다음줄로 넘어가기 위한 변수
            _stride = (int)(_description.Width * _description.BytesPerPixel);
            _sensor.Open();

            this.DataContext = this;

            InitializeComponent();
        }

        private void _depthFrameReader_FrameArrived(object sender, DepthFrameArrivedEventArgs e)
        {
            using (DepthFrame depthFrame = e.FrameReference.AcquireFrame())
            {
                if (depthFrame != null)
                {
                    depthFrame.CopyFrameDataToArray(_buffer);

                    for (int i = 0; i < _buffer.Length; i++)
                    {
                        //8미터가 거의 최대인식거리 이므로 8000으로 나눠줬다
                        _buffer[i] = (ushort)(_buffer[i] * 65535 / 8000);
                    }

                    _bitmap.WritePixels(new Int32Rect(0, 0, _bitmap.PixelWidth, _bitmap.PixelHeight), _buffer, _stride, 0);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_depthFrameReader != null)
            {
                _depthFrameReader.Dispose();
                _depthFrameReader = null;
            }

            if (_sensor != null)
            {
                _sensor.Close();
                _sensor = null;
            }
        }
    }
}
