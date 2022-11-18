using ImageMagick;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppFotos4x4
{
    public class App
    {

        public Path paths { get; set; }
        public int posicion = 0;
        public string plantillaFinal;
        Random rnd = new Random();
       
        public void crearImagen(string ruta, int cantidad)
        {
          
            using (MagickImage nueva = new MagickImage(ruta))
            {
                try{
                    int num = rnd.Next(1000);
                    num++;
                    nueva.AdaptiveResize(450, 450);
                    string final = @"C:\Users\Juan\Downloads\10000" + num.ToString() + ".jpg";
                    MagickImage plantilla = new MagickImage(@"C:\Users\Juan\Downloads\hojaA4.jpg");
                    plantilla.Composite(nueva, 100, 100);

                    plantilla.Write(final);
                    if (cantidad > 1)
                    {
                        int i = 1;
                        while (i++ < cantidad)
                        {
                            MagickImage nueva2 = new MagickImage(final);
                            num++;
                            posicion = posicion + 600;
                            plantilla.Composite(nueva, posicion, 100);
                            string final2 = @"C:\Users\Juan\Downloads\10000" + num.ToString() + ".jpg";
                            plantillaFinal = final2;
                        }
                        plantilla.Write(final);

                        MessageBox.Show("Imagenes generadas con exito.");
                    }
                }catch{
                    MessageBox.Show("error");
                }


                }
        }
            
            
        
    }
}

