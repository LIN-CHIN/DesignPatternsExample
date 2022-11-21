using Newtonsoft.Json;
using System;

namespace Prototype_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextBox textBox = new TextBox()
            {
                Name = "TextBox1",
                Width = 100,
                Height = 100,
                X = 0,
                Y = 0,
                Font = new Font()
                {
                    Size = 12,
                    Color = "red"
                }
            };

            TextBox textBox2 = textBox.DeepCopy();

            Console.WriteLine("before T1 :" + JsonConvert.SerializeObject(textBox));
            Console.WriteLine("before T2 :" + JsonConvert.SerializeObject(textBox2));

            textBox2.Name = "Test";
            textBox2.Width = 200;
            textBox2.Height = 200;
            textBox2.X = 500;
            textBox2.Y = 500;
            textBox2.Font.Size = 24;
            textBox2.Font.Color = "blue";


            Console.WriteLine("after T1 :" + JsonConvert.SerializeObject(textBox));
            Console.WriteLine("after T2 :" + JsonConvert.SerializeObject(textBox2));

        }
    }
}
