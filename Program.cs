using System;
using System.Drawing;

namespace myApp
{
    public static class Snippet
    {
        public static System.Boolean AnadirEtiquetaImagen(System.String Codigo, System.String DescripcionPrimera, System.String DescripcionMedia, System.String DescripcionFinal, System.String Precio, System.String Fuente, System.String Destino, System.String Color)
        {
            try
            {

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;

                Font font = new Font("Arial Rounded MT Bold", 14, FontStyle.Bold);
                Brush brush = new SolidBrush(ColorTranslator.FromHtml(Color));
                Bitmap imagenBitmap = new Bitmap(Fuente);

                float x = 2.0F;
                float width = 165.0F;
                float height = 20.0F;

                Image image = Image.FromFile(Fuente);
                Graphics graphics = Graphics.FromImage(image);
                graphics.DrawImage(image, 0, 0);
                graphics.DrawString(Codigo, font, brush, new RectangleF(x, 10, width, height), sf);
                graphics.DrawString(DescripcionPrimera, font, brush, new RectangleF(x, 50, width, height), sf);
                graphics.DrawString(DescripcionMedia, font, brush, new RectangleF(x, 70, width, height), sf);
                graphics.DrawString(DescripcionFinal, font, brush, new RectangleF(x, 90, width, height), sf);
                graphics.DrawString(Precio, font, brush, new RectangleF(x, 130, width, height), sf);
                graphics.Save();

                image.Save(Destino, System.Drawing.Imaging.ImageFormat.Png);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Snippet.AnadirEtiquetaImagen("ABCD", "Description1", "Descripcion2", "Description3", "500.00", @"C:\Argos_Sistems_1.00\Argos_Imagenes\Argos_Punto de Ventas\Botones\Articulos\Michells\Fuentes\2.png", @"C:\Argos_Sistems_1.00\Argos_Imagenes\Argos_Punto de Ventas\Botones\Articulos\Michells\Fuentes\erick.png", "#000000");
        }
    }
}
