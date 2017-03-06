using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_lab1
{
    class ImageUtil
    {
        private static List<List<int>> getConvMatrix(FilterType type)
        {
            List<List<int>> matrix = new List<List<int>>();

            switch (type)
            {
                case FilterType.blur:
                    matrix.Add(new List<int>(new int[] { 1, 1, 1 }));
                    matrix.Add(new List<int>(new int[] { 1, 1, 1 }));
                    matrix.Add(new List<int>(new int[] { 1, 1, 1 }));
                    break;
                case FilterType.gaussian_smoothing:
                    matrix.Add(new List<int>(new int[] { 0, 1, 0 }));
                    matrix.Add(new List<int>(new int[] { 1, 4, 1 }));
                    matrix.Add(new List<int>(new int[] { 0, 1, 0 }));
                    break;
                case FilterType.sharpen:
                    matrix.Add(new List<int>(new int[] { 0, -1, 0 }));
                    matrix.Add(new List<int>(new int[] { -1, 5, -1 }));
                    matrix.Add(new List<int>(new int[] { 0, -1, 0 }));
                    break;
                case FilterType.edge_detection:
                    matrix.Add(new List<int>(new int[] { -1, -1, -1 }));
                    matrix.Add(new List<int>(new int[] { -1, 8, -1 }));
                    matrix.Add(new List<int>(new int[] { -1, -1, -1 }));
                    break;
                case FilterType.emboss:
                    matrix.Add(new List<int>(new int[] { -1, -1, 0 }));
                    matrix.Add(new List<int>(new int[] { -1, 1, 1 }));
                    matrix.Add(new List<int>(new int[] { 0, 1, 1 }));
                    break;

            }
            return matrix;
        }
        public static Bitmap inverse(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            for (int y = 0; y <input.Height; y++)
            {
                for (int x = 0; x <input.Width; x++)
                {
                    Color inv = input.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    output.SetPixel(x, y, inv);
                }
            }
            return output;
        }


        public static Bitmap brigthness_correction(Bitmap input)
        {

            if (input == null)
            {
                MessageBox.Show("Upload image first");
                return null;
                
            }

            Bitmap output = new Bitmap(input.Width, input.Height);
            for (int y = 0; y <input.Height; y++)
            {
                for (int x = 0; x <input.Width; x++)
                {
                    Color bri= input.GetPixel(x, y);
                    //inv = Color.FromArgb(255, (int)(255 * System.Math.Pow((double)inv.R / (double)255, 1 / gamma)), (int)(255 * System.Math.Pow((double)inv.G / (double)255, 1 / gamma)), (int)(255 * System.Math.Pow((double)inv.B / (double)255, 1/gamma)));
                    int brightness = 80; // brightness level

                    int briR = bri.R + brightness;
                    int briG = bri.G + brightness;
                    int briB = bri.B + brightness;

                    if (briR < 0)
                        briR = 0;
                    if (briR > 255) 
                        briR = 255;
                    if (briG < 0) 
                        briG = 0;
                    if (briG > 255) 
                        briG = 255;
                    if (briB < 0) 
                        briB = 0;
                    if (briB > 255) 
                        briB = 255;

                    output.SetPixel(x, y, Color.FromArgb(255, briR, briG, briB));
                }
            }
            return output;
        }


        public static Bitmap contrast(Bitmap input)
        {
           Bitmap output = new Bitmap(input.Width, input.Height);
           double contrast = 30; // contrast level
           contrast = System.Math.Pow(((100 + contrast) / 100), 2);
           for (int x = 0; x < input.Width; x++)
           {

            for (int y = 0; y < input.Height; y++)
            {
                   Color con = input.GetPixel(x,y);
                   double conR = ((((con.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    if (conR < 0)
                        conR = 0;
                    if (conR > 255)
                        conR = 255;

                   double conG = ((((con.G / 255.0) - 0.5) * contrast) + 0.5)* 255.0;
                    if (conG < 0)
                        conG = 0;
                    if (conG > 255)
                        conG = 255;

                   double conB = ((((con.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    if (conB < 0)
                        conB = 0;
                    if (conB > 255)
                        conB = 255;
    
                 output.SetPixel(x,y, Color.FromArgb((int)conR, (int)conG, (int)conB));

                }
            }

            return output;
        }
        public enum FilterType{
            blur,
            sharpen,
            gaussian_smoothing,
            edge_detection,
            emboss,
            custom
        }

        public static Bitmap convolutionFilter(Bitmap bmpInput, FilterType type)
        {
            Bitmap output = new Bitmap(bmpInput.Width, bmpInput.Height);
            Color c;
            float sumR = 0, sumG = 0, sumB = 0;
            int counterX=0, counterY=0;
            int convSizeY,convSizeX;
            List<List<int>>matrix = ImageUtil.getConvMatrix(type);

            int weightsSum = 0;
            matrix.ForEach(x => { x.ForEach(y => { weightsSum += y; }); });
            if (weightsSum == 0) { weightsSum = 1; }

            convSizeY = matrix.Count;
            convSizeX = matrix.First().Count;

            int xSide = (convSizeX - 1) / 2;
            int ySide = (convSizeY - 1) / 2;
            for (int i = xSide; i <= bmpInput.Width - 1 - xSide; i++)
                for (int j = ySide; j <= bmpInput.Height - 1 - ySide; j++)
                {
                    counterX = 0;
                    for (int x = i - xSide; x <= i + xSide; x++,counterX++,counterY=0)
                        for (int y = j - ySide; y <= j + ySide; y++, counterY++)
                        {
                            c = bmpInput.GetPixel(x, y);
                            sumR = sumR + c.R * matrix[counterY][counterX];
                            sumG = sumG + c.G * matrix[counterY][counterX];
                            sumB = sumB + c.B * matrix[counterY][counterX];
                        }
                    int colorR = (int)Math.Round(sumR / weightsSum);
                    int colorG = (int)Math.Round(sumG / weightsSum);
                    int colorB = (int)Math.Round(sumB / weightsSum);

                    if (colorR < 0)
                        colorR = 0;
                    if (colorR > 255)
                        colorR = 255;

                    if (colorG < 0)
                        colorG = 0;
                    if (colorG > 255)
                        colorG = 255;

                    if (colorB < 0)
                        colorB = 0;
                    if (colorB > 255)
                        colorB = 255;


                    output.SetPixel(i, j, Color.FromArgb(colorR, colorG, colorB));
                    sumR = 0;
                    sumB = 0;
                    sumG = 0;
                }
            return output;
        }
        /*public static Bitmap convolutionFilter(Bitmap bmpInput, List<List<int>> matrix, int offset, int anchorX, int anchorY, int divisor)
        {
            Bitmap output = new Bitmap(bmpInput.Width, bmpInput.Height);
            Color c;
            float sumR = 0, sumG = 0, sumB = 0;
            int counterX = 0, counterY = 0;
            int convSizeY, convSizeX;

            convSizeY = matrix.Count;
            convSizeX = matrix.First().Count;

            int xSide = (convSizeX - 1) / 2;
            int ySide = (convSizeY - 1) / 2;


            for (int i = xSide; i <= bmpInput.Width - 1 - xSide; i++)
                for (int j = ySide; j <= bmpInput.Height - 1 - ySide; j++)
                {
                    counterX = 0;
                    for (int x = i - xSide; x <= i + xSide; x++, counterX++, counterY = 0)
                        for (int y = j - ySide; y <= j + ySide; y++, counterY++)
                        {
                            c = bmpInput.GetPixel(x, y);
                            sumR = sumR + c.R * matrix[counterY][counterX]; //+ offset;
                            sumG = sumG + c.G * matrix[counterY][counterX];//+ offset;
                            sumB = sumB + c.B * matrix[counterY][counterX]; //+ offset;
                        }
                    int colorR = (int)Math.Round((sumR / divisor)+ offset);
                    int colorG = (int)Math.Round((sumG / divisor)+ offset);
                    int colorB = (int)Math.Round((sumB / divisor)+ offset);

                    if (colorR < 0)
                        colorR = 0;
                    if (colorR > 255)
                        colorR = 255;

                    if (colorG < 0)
                        colorG = 0;
                    if (colorG > 255)
                        colorG = 255;

                    if (colorB < 0)
                        colorB = 0;
                    if (colorB > 255)
                        colorB = 255;


                    output.SetPixel(i, j, Color.FromArgb(colorR, colorG, colorB));
                    sumR = 0;
                    sumB = 0;
                    sumG = 0;
                }
            return output;
        }  */



        public static Bitmap convolutionFilter(Bitmap bmpInput, List<List<int>> matrix, int offset, int anchorX, int anchorY, int divisor)
        {
            Bitmap output = new Bitmap(bmpInput.Width, bmpInput.Height);
            Color c;
            float sumR = 0, sumG = 0, sumB = 0;
            int counterX = 0, counterY = 0;
            int convSizeY, convSizeX;

            convSizeY = matrix.Count;
            convSizeX = matrix.First().Count;

            //int xSide = (convSizeX - 1) / 2;
            //int ySide = (convSizeY - 1) / 2;

            int x_anchor_fromleft = (convSizeX - anchorX - 1 );
            int y_anchor_frombottom = (convSizeY - anchorY -1);

            for (int i = anchorX; i <= bmpInput.Width - 1 - x_anchor_fromleft; i++)
                for (int j = anchorY; j <= bmpInput.Height - 1 - y_anchor_frombottom; j++)
                {
                    counterX = 0;
                    for (int x = i - anchorX; x <= i + x_anchor_fromleft ; x++, counterX++, counterY = 0)
                        for (int y = j - anchorY; y <= j + y_anchor_frombottom ; y++, counterY++)
                        {
                            c = bmpInput.GetPixel(x, y);
                            sumR = sumR + c.R * matrix[counterY][counterX]; //+ offset;
                            sumG = sumG + c.G * matrix[counterY][counterX];//+ offset;
                            sumB = sumB + c.B * matrix[counterY][counterX]; //+ offset;
                        }
                    int colorR = (int)Math.Round((sumR / divisor) + offset);
                    int colorG = (int)Math.Round((sumG / divisor) + offset);
                    int colorB = (int)Math.Round((sumB / divisor) + offset);

                    if (colorR < 0)
                        colorR = 0;
                    if (colorR > 255)
                        colorR = 255;

                    if (colorG < 0)
                        colorG = 0;
                    if (colorG > 255)
                        colorG = 255;

                    if (colorB < 0)
                        colorB = 0;
                    if (colorB > 255)
                        colorB = 255;


                    output.SetPixel(i, j, Color.FromArgb(colorR, colorG, colorB));
                    sumR = 0;
                    sumB = 0;
                    sumG = 0;
                }
            return output;
        }











      /*  public static Bitmap blur(Bitmap bmpInput, int convSizeX, int convSizeY)
        {

           Bitmap output = new Bitmap(bmpInput.Width, bmpInput.Height);
           Color c;
           float sumR = 0, sumG = 0, sumB = 0;
           int xSide = (convSizeX -1) /2;
           int ySide = (convSizeY -1) /2;
           for (int i = xSide; i <= bmpInput.Width - 1 - xSide; i++)
               for (int j = ySide; j <= bmpInput.Height - 1 - ySide; j++)
                {
                    for (int x = i - xSide; x <= i + xSide; x++)
                        for (int y = j - ySide; y <= j + ySide; y++)
                        {
                            c = bmpInput.GetPixel(x,y);
                            sumR = sumR +  c.R ;
                            sumG = sumG + c.G;
                            sumB = sumB + c.B;
                        }
                    int colorR = (int)Math.Round(sumR / (convSizeX * convSizeY));
                    int colorG = (int)Math.Round(sumG / (convSizeX * convSizeY));
                    int colorB = (int)Math.Round(sumB / (convSizeX * convSizeY));
                    output.SetPixel(i, j, Color.FromArgb(colorR, colorG, colorB));
                    sumR = 0;
                    sumB = 0;
                    sumG = 0;
                }
            return output;

        }*/




    }
}
