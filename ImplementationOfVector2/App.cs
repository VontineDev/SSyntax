using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfVector2
{
    struct Vector2
    {
        public float X, Y;

        float Magnitude() => MathF.Sqrt(X * X + Y * Y);

        //자바에서라면 이렇게 해야한다지만
        //Vector2 Add(Vector2 v1, Vector2 v2)
        //{            
        //    var result = new Vector2();
        //    result.X = v1.X + v2.X;
        //    result.Y = v1.Y + v2.Y;
        //    return result;
        //}

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            var result = new Vector2();
            result.X = v1.X + v2.X;
            result.Y = v1.Y + v2.Y;
            return result;
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            var result = new Vector2();
            return result;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";

        }
    }

    class Stack<T>
    {
        T[] data;
        int top = 0;
        public Stack(int capa)
        {
            data = new T[capa];
        }

        public void Push(T num)
        {
            data[top++] = num;

        }

        public T Pop()
        {
            return data[--top];

        }

        public int Count()
        {
            return top;
        }
        public void Clear()
        {
            top = 0;
        }
    }

    class Shape
    {
        public virtual float Area()
        {
            return 0;
        }
    }
    class Circle : Shape
    {
        private float x, y, radius;
        public Circle(float x, float y, float radius)       //생성자
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override float Area()
        {
            return MathF.PI * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        public float x, y, width, height;
        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override float Area()
        {
            return width * height;
        }
    }
    class App
    {
        public App()
        {
            //Vector2 v = new Vector2();
            //v.X = 1;
            //v.Y = 2;
            //Console.WriteLine(v);

            //TestVector(v);
            //Console.WriteLine($"{v.X},{v.Y}");



            //var s = new Stack<int>(10);
            ////Console.WriteLine(s.Count());
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);
            //s.Push(4);
            //s.Push(5);
            //s.Push(6);
            //s.Push(7);
            //s.Push(8);
            //s.Push(9);
            //s.Push(10);

            //Console.WriteLine($"Count is : {s.Count()}");
            ////s.Clear();
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());

            Shape[] shapes = new Shape[4];

            shapes[0] = new Circle(1, 2, 5);
            shapes[1] = new Circle(3, 4, 15);
            shapes[2] = new Rectangle(1, 2, 5, 10);
            shapes[3] = new Rectangle(2, 3, 2, 1);

            Console.WriteLine($"Total Area: {TotalArea(shapes)}");


        }
        float TotalArea(Shape[] shapes)
        {
            float result = 0;
            foreach (var s in shapes)
            {
                result += s.Area();
            }
            return result;
        }
        void TestVector(Vector2 vector)
        {
            vector.X = 100;
            vector.Y = 200;
        }
    }
}
