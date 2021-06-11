using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

//using System.Windows.Shapes; //Shape는 키넥트와 이름이 많이 겹치므로 없애준다

using Microsoft.Kinect;



namespace KinectPractice
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private KinectSensor _sensor = null;
        private ColorFrameReader _colorFrameReader = null;
        private WriteableBitmap _bitmap = null;

        public ImageSource ImageSource
        {
            get { return _bitmap; }
        }

        public MainWindow()
        {
            _sensor = KinectSensor.GetDefault(); //키넥트 센서를 가져온다
            _colorFrameReader = _sensor.ColorFrameSource.OpenReader();
            //Kinect 2 는 1920*1080으로 가져오는데 이 이미지의 크기를 모른다고 가정하고, 기본 정보를 가져온다.
            FrameDescription description = _sensor.ColorFrameSource.CreateFrameDescription(ColorImageFormat.Bgra);
            //비트맵할당
            _bitmap = new WriteableBitmap(description.Width, description.Height, 96, 96, PixelFormats.Bgra32, null);

            _sensor.Open(); //센서켜기

            _colorFrameReader.FrameArrived += _colorFrameReader_FrameArrived;

            this.DataContext = this;

            InitializeComponent();
        }

        private void _colorFrameReader_FrameArrived(object sender, ColorFrameArrivedEventArgs e)
        {
            using (ColorFrame colorFrame = e.FrameReference.AcquireFrame())
            {
                if (colorFrame != null)
                {
                    FrameDescription des = colorFrame.FrameDescription;
                    using (KinectBuffer buffer = colorFrame.LockRawImageBuffer())
                    {
                        _bitmap.Lock();
                        colorFrame.CopyConvertedFrameDataToIntPtr(_bitmap.BackBuffer,
                            (uint)((des.Width) * (des.Height) * 4), ColorImageFormat.Bgra);

                        _bitmap.AddDirtyRect(new Int32Rect(0, 0, 1920, 1080));

                        _bitmap.Unlock();

                        //Name = "imgControl" 하고같이 쓸 수 있으나 잘 안쓰는 방식
                        //imgControl.Source = _bitmap;


                    }
                }
            }
        }
    }
}
