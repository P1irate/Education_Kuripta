using SharpGL;
using SharpGL.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace test
{
    class Figur
    {
        public OpenGL square1(OpenGLControl openGLControl)
    {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(270, 170, 0, 0, 0, "", 20, "a");
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для квадрата
            gl.Vertex(-1f, -1f);
            gl.Vertex(-1f, 1f);
            gl.Vertex(1f, 1f);
            gl.Vertex(1f, -1f);
            //выход из режима
            gl.End();
            return gl;

        }

        public void square2(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 

            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(180, 160, 0, 0, 0, "", 20, "d");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для квадрата
            gl.Vertex(-1f, -1f);
            gl.Vertex(-1f, 1f);
            gl.Vertex(1f, 1f);
            gl.Vertex(1f, -1f);
            gl.Vertex(-1f, -1f);
            gl.Vertex(1f, 1f);
            //выход из режима
            gl.End();
        }

        public void rectangle(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 90, 0, 0, 0, "", 20, "a");
            gl.DrawText(45, 170, 0, 0, 0, "", 20, "b");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для прямоугольника
            gl.Vertex(-1.25f, -0.75f);
            gl.Vertex(-1.25f, 0.75f);
            gl.Vertex(1.25f, 0.75f);
            gl.Vertex(1.25f, -0.75f);
            //выход из режима
            gl.End();
        }

        public void triangle1(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(165, 170, 0, 0, 0, "", 20, "h");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для треугольника
            gl.Vertex(-1, -1);
            gl.Vertex(-0.2, 1);
            gl.Vertex(-0.2, -1);
            gl.Vertex(-0.2, 1);
            gl.Vertex(1, -1);
            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для прямого угла
            gl.Vertex(0.1f, -0.7f);
            gl.Vertex(-0.2f, -0.7f);
            gl.Vertex(0.1f, -0.7f);
            gl.Vertex(0.1f, -1f);
            gl.End();
        }

        public void triangle2(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(100, 170, 0, 0, 0, "", 20, "b");
            gl.DrawText(105, 105, 0, 0, 0, "", 16, "y");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для треугольника
            gl.Vertex(-1, -1);
            gl.Vertex(-0.2, 1);
            gl.Vertex(1, -1);
            gl.End();

            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_STRIP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для угла "у"
            for (int i = -3; i < 30; i++)
            {
                double angle = 3.1415926 * i / 50;
                double dx = 0.1 * Math.Cos(angle);
                double dy = 0.1 * Math.Sin(angle);
                gl.Vertex(-0.94 + dx, -0.98 + dy);
            }
            //выоход из режима
            gl.End();
        }

        public void triangle3(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(100, 170, 0, 0, 0, "", 20, "b");
            gl.DrawText(217, 170, 0, 0, 0, "", 20, "c");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для треугольника
            gl.Vertex(-1, -1);
            gl.Vertex(-0.2, 1);
            gl.Vertex(1, -1);
            gl.End();
        }

        public void triangle4(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(112, 150, 0, 0, 0, "", 20, "b");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для треугольника
            gl.Vertex(-0.5, 1);
            gl.Vertex(-0.5, -1);
            gl.Vertex(1, -1);
            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для прямого угла
            gl.Vertex(-0.2f, -0.7f);
            gl.Vertex(-0.5f, -0.7f);
            gl.Vertex(-0.2f, -0.7f);
            gl.Vertex(-0.2f, -1f);
            gl.End();
        }

        public void triangle5(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(165, 70, 0, 0, 0, "", 20, "a");
            gl.DrawText(110, 170, 0, 0, 0, "", 20, "a");
            gl.DrawText(220, 170, 0, 0, 0, "", 20, "a");
            gl.DrawText(105, 100, 0, 0, 0, "", 14, "60");
            gl.DrawText(123, 110, 0, 0, 0, "", 8, "o");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для треугольника
            gl.Vertex(-1, -1);
            gl.Vertex(0, 0.7);
            gl.Vertex(1, -1);
            gl.End();

            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_STRIP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для угла "у"
            for (int i = -3; i < 26; i++)
            {
                double angle = 3.1415926 * i / 50;
                double dx = 0.1 * Math.Cos(angle);
                double dy = 0.1 * Math.Sin(angle);
                gl.Vertex(-0.94 + dx, -0.98 + dy);
            }
            //выоход из режима
            gl.End();
        }

        public void parallelogram1(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(70, 175, 0, 0, 0, "", 20, "a");
            gl.DrawText(150, 125, 0, 0, 0, "", 20, "h");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для параллелограмма
            gl.Vertex(-1.2f, -1f);
            gl.Vertex(-0.7, 1);
            gl.Vertex(1.3, 1f);
            gl.Vertex(0.8, -1f);
            gl.Vertex(-1.08, -0.5);
            gl.Vertex(0.8, -1f);
            //выход из режима
            gl.End();
        }

        public void parallelogram2(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            //цвет поля
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(125, 154, 0, 0, 0, "", 20, "d");
            gl.DrawText(138, 152, 0, 0, 0, "", 12, "1");
            gl.DrawText(150, 213, 0, 0, 0, "", 20, "d");
            gl.DrawText(163, 211, 0, 0, 0, "", 12, "2");
            gl.DrawText(195, 170, 0, 0, 0, "", 16, "y");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для параллелограмма
            gl.Vertex(-1.2f, -1f);
            gl.Vertex(1.3, 1f);
            gl.Vertex(-1.2f, -1f);
            gl.Vertex(-0.7, 1);
            gl.Vertex(0.8, -1f);
            gl.Vertex(-0.7, 1);
            gl.Vertex(1.3, 1f);
            gl.Vertex(0.8, -1f);
            //выход из режима
            gl.End();

            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_STRIP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для угла "у"
            for (int i = -16; i < 17; i++)
            {
                double angle = 3.1415926 * i / 50;
                double dx = 0.1 * Math.Cos(angle);
                double dy = 0.1 * Math.Sin(angle);
                gl.Vertex(0.08 + dx, -0.01 + dy);
            }
            //выоход из режима
            gl.End();

            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_STRIP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для угла "у"
            for (int i = -16; i < 16; i++)
            {
                double angle = 3.1415926 * i / 50;
                double dx = 0.15 * Math.Cos(angle);
                double dy = 0.15 * Math.Sin(angle);
                gl.Vertex(0.08 + dx, -0.01 + dy);
            }
            //выоход из режи    
            gl.End();
        }

        public void rhombus1(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(100, 110, 0, 0, 0, "", 20, "a");
            gl.DrawText(85, 172, 0, 0, 0, "", 16, "y");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для ромба
            gl.Vertex(-1.25f, 0f);
            gl.Vertex(0f, 0.9f);
            gl.Vertex(1.25f, 0f);
            gl.Vertex(0f, -0.9f);
            //выход из режима
            gl.End();

            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_STRIP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для угла "у"
            for (int i = -15; i < 15; i++)
            {
                double angle = 3.1415926 * i / 50;
                double dx = 0.1 * Math.Cos(angle);
                double dy = 0.1 * Math.Sin(angle);
                gl.Vertex(-1.2 + dx, 0 + dy);
            }
            //выоход из режима
            gl.End();
        }

        public void priombus2(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(130, 183, 0, 0, 0, "", 20, "d");
            gl.DrawText(143, 181, 0, 0, 0, "", 12, "1");
            gl.DrawText(177, 200, 0, 0, 0, "", 20, "d");
            gl.DrawText(190, 198, 0, 0, 0, "", 12, "2");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для ромба
            gl.Vertex(-1.25f, 0f);
            gl.Vertex(1.25f, 0f);
            gl.Vertex(-1.25f, 0f);
            gl.Vertex(0f, 0.9f);
            gl.Vertex(0f, -0.9f);
            gl.Vertex(0f, 0.9f);
            gl.Vertex(1.25f, 0f);
            gl.Vertex(0f, -0.9f);
            //выход из режима
            gl.End();
        }

        public void priombus3(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(100, 150, 0, 0, 0, "", 20, "a");
            gl.DrawText(160, 145, 0, 0, 0, "", 20, "h");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для ромба
            gl.Vertex(-1f, -0.9f);
            gl.Vertex(-0.2f, 0.4f);
            gl.Vertex(-0.2f, -0.9f);
            gl.Vertex(-0.2f, 0.4f);
            gl.Vertex(1.25f, 0.4f);
            gl.Vertex(0.45f, -0.9f);
            //выход из режима
            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для прямого угла
            gl.Vertex(-0f, -0.7f);
            gl.Vertex(-0.2f, -0.7f);
            gl.Vertex(-0f, -0.7f);
            gl.Vertex(-0f, -0.9f);
            gl.End();
        }

        public void trapezoid(OpenGLControl openGLControl)
        {
            //ссылка на элемент управления OpenGL 
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(255, 255, 255, 1);
            //чистка буфера кадра 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //загрузка нулевой матрицы мировых координат
            gl.LoadIdentity();
            //подписи
            gl.DrawText(170, 90, 0, 0, 0, "", 20, "a");
            gl.DrawText(170, 250, 0, 0, 0, "", 20, "b");
            gl.DrawText(110, 150, 0, 0, 0, "", 20, "h");
            //двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            //соединение вершин
            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для трапеции
            gl.Vertex(-1.25f, -0.75f);
            gl.Vertex(-0.5f, 0.75f);
            gl.Vertex(1f, 0.75f);
            gl.Vertex(1.25f, -0.75f);
            gl.Vertex(-1.25f, -0.75f);
            gl.Vertex(-0.5f, -0.75f);
            gl.Vertex(-0.5f, 0.75f);
            //выход из режима
            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            //цвет вершин
            gl.Color(0, 0, 0);
            //список вершин для прямого угла
            //список вершин для прямого угла
            //список вершин для прямого угла
            //список вершин для прямого угла
            gl.Vertex(-0.2f, -0.45f);
            gl.Vertex(-0.5f, -0.45f);
            gl.Vertex(-0.2f, -0.45f);
            gl.Vertex(-0.2f, -0.75f);
            gl.End();
        }
    }
}
