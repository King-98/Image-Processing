using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영상처리_공부자료
{
    class histogram
    {
        Bitmap bitmap, newColor;
        Color color;
        int[,] colorArray;
        int[] histogramArray = new int[256];
        int x, y, max = 0;

        public histogram(Bitmap bit)
        {
            bitmap = bit;
            newColor = new Bitmap(bitmap, bitmap.Width, bitmap.Height);
            colorArray = new int[bitmap.Width, bitmap.Height];
        }

        public void histo_init()
        {
            Gray();

            // 명암값 불러오기
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    histogramArray[colorArray[x, y]]++;
                }
            }

            // 히스토그램에서 가장 높은 값을 구함
            for (x = 0; x < 256; x++)
            {
                if (max < histogramArray[x])
                    max = histogramArray[x];
            }
        }

        public Bitmap Gray()
        {
            Color gray;
            int brightness;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    brightness = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                    gray = Color.FromArgb(brightness, brightness, brightness);
                    colorArray[x,y] = brightness;
                    newColor.SetPixel(x, y, gray);//초기화를 해야지 set을함
                }
            return newColor;
        }

        public Bitmap histogramview()
        {
            /*
             *  1. gray값으로 histogram[255]를 구한다
             *  2. for문으로 검사하면서 그배열의 값이 그값보다 높으면 검은색
             */
             
            histo_init();

            newColor = new Bitmap(bitmap, 256, max);

            for (y = max - 1; y >= 0; y--)
            {
                for (x = 0; x < 256; x++)
                {
                    if (histogramArray[x] > max - 1 - y)
                        newColor.SetPixel(x, y, Color.Black);
                    else
                        newColor.SetPixel(x, y, Color.White);
                }
            }

            return newColor;
        }

        public Bitmap basicStretch()
        {
            Gray();
            histo_init(); // 히스토그램 초기화

            int x, y;
            int alpha = 0, beta = 255;
            int[] LUT = new int[256];

            // alpha, beta 구함
            for(x=0; x<256; x++)
            {
                if (histogramArray[x] != 0)
                {
                    alpha = x;
                    break;
                }
            }
            for(x=255; x>0; x--)
            {
                if (histogramArray[x] != 0)
                {
                    beta = x;
                    break;
                }
            }

            //나머지영역 설정
            for (x = 0; x < alpha; x++) LUT[x] = 0;
            for (x = 255; x > beta; x--) LUT[x] = 255;

            //a~b영역 설정
            for (x = alpha; x <= beta; x++)
                LUT[x] = (int)((x - alpha) * 255.0 / (beta - alpha));
            
            /*
            for(x=0; x < 256; x++)
            {
                Console.WriteLine("LUT[" + x + "] : " + LUT[x]);
            }
            */

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    colorArray[x, y] = LUT[colorArray[x, y]];
                    color = Color.FromArgb(colorArray[x, y], colorArray[x, y], colorArray[x, y]);
                    newColor.SetPixel(x, y, color);
                }
            }

            return newColor;
        }

        public Bitmap adjustBright()
        {
            Gray();

            const int brightValue = 75; // 밝기 벨류
            int x, y, index, newValue;
            int[] LUT = new int[256];

            for (index = 0; index < 256; index++)
            {
                newValue = index + brightValue;
                if (newValue > 255) newValue = 255;
                if (newValue < 0) newValue = 0;
                LUT[index] = newValue; //0~255까지 75를 더한값이 들어감
            }

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    colorArray[x, y] = LUT[colorArray[x, y]]; //예를들어 75의 값을 넣으면 75번쨰 배열엔 150이 들어가있으므로 더함
                    color = Color.FromArgb(colorArray[x, y], colorArray[x, y], colorArray[x, y]);
                    newColor.SetPixel(x, y, color);
                }
            }

            return newColor;
        }

        public Bitmap equalization()
        {
            Gray();
            histo_init();

            int x, y;
            int sum = 0;
            int[] LUT = new int[256];
            int numberOfPixels = bitmap.Width * bitmap.Height;
            double scale = 255.0 / numberOfPixels;

            for (x = 0; x < 256; x++)
            {
                sum += histogramArray[x]; //누적합 명암개수
                LUT[x]=(int)(sum*scale+0.5);
            }

            for (x = 0; x < 256; x++)
            {
                Console.WriteLine("LUT[" + x + "] : " + LUT[x]);
            }

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    colorArray[x, y] = LUT[colorArray[x, y]];
                    color = Color.FromArgb(colorArray[x, y], colorArray[x, y], colorArray[x, y]);
                    newColor.SetPixel(x, y, color);
                }
            }

            return newColor;
        }

        public Bitmap equalization_2()
        {
            Gray();
            histo_init();
            int sum=0;
            int avg,per;
            int[] LUT = new int[256];

            for (x = 0; x < 256; x++)
            {
                sum += x*histogramArray[x];
            }
            avg = sum/255/255;

            for (x = 0; x < 256; x++)
            {
                per = Math.Abs((avg - x) / avg);
                Console.WriteLine("per[" + x + "] : " + per);
            }

            return newColor;
        }
    }
}
