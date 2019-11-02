using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 영상처리_공부자료
{
    class IP
    {
        Bitmap bitmap,newBit;
        Color color;
        int[,] colorArray;

        public IP(Bitmap bit)
        {
            bitmap = bit;
            newBit = new Bitmap(bitmap, bitmap.Width, bitmap.Height);
            colorArray = new int[bitmap.Width,bitmap.Height];
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
                    colorArray[x, y] = brightness;
                    newBit.SetPixel(x, y, gray);//초기화를 해야지 set을함
                }
            return newBit;
        }

        public Bitmap binary()
        {
            Gray();
            int avg = 0;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                    avg += colorArray[x, y];//colorArray는 불러온 이미지의 가로세로로 초기화한 3차원 Int형 배열
                                            //모든색깔의 명암을 더함
            avg /= bitmap.Height * bitmap.Width;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (avg > colorArray[x, y])
                        newBit.SetPixel(x, y, Color.White);
                    else
                        newBit.SetPixel(x, y, Color.Black);
                }

            return newBit;
        }

        public Bitmap maxminbinary()//시킬것
        {
            Gray();
            int avg = 0;
            int max = 0, min = 256;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (max < colorArray[x, y])
                        max = colorArray[x, y];
                    if (min > colorArray[x, y])
                        min = colorArray[x, y];
                }

            avg = (max + min) / 2;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (avg > colorArray[x, y])
                    {
                        newBit.SetPixel(x, y, Color.White);
                        colorArray[x, y] = 255;
                    }
                    else
                    {
                        newBit.SetPixel(x, y, Color.Black);
                        colorArray[x, y] = 0;
                    }
                }

            return newBit;
        }

        public Bitmap roiarea()
        {
            Gray();
            maxminbinary();
            int[] start = new int[2];
            int[] end = new int[2];
            int x2=0, y2=0;
            int x, y;

            start[0] = bitmap.Width;//왼쪽
            start[1] = bitmap.Height;//아래
            end[0] = 0;//오른쪽
            end[1] = 0;//위쪽

            for (y = 0; y<bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    if (colorArray[x, y] == 255)
                    {
                        if (start[0] > x)
                            start[0] = x;//왼
                        if (start[1] > y)
                            start[1] = y;//밑
                        if (end[0] < x)
                            end[0] = x;//오른
                        if (end[1] < y)
                            end[1] = y;//위
                    }
                }
            }

            newBit = new Bitmap(bitmap, end[0] - start[0], end[1] - start[1]);

            //원본파일 복사
            for (y = start[1]; y < end[1]; y++)
            {
                x2 = 0;
                for (x = start[0]; x < end[0]; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    newBit.SetPixel(x2, y2, color);
                    x2++;
                }
                y2++;
            }

            return newBit;
        }

        public Bitmap brightup() // 밝게
        {
            int x, y;
            Color Brightness;
            int red, green, blue;

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    red = color.R + 50;
                    green = color.G + 50;
                    blue = color.B + 50;

                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;

                    Brightness = Color.FromArgb(red,green,blue);
                    newBit.SetPixel(x, y, Brightness);
                }
            }

            return newBit;
        }

        public Bitmap flow()
        {
            int x, y;
            Color flow;
            int red = 0,
                green = 0,
                blue = 255;

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);

                    red += 1;
                    if (red > 255) red = 255;

                    flow = Color.FromArgb(red, green, blue);
                    newBit.SetPixel(x, y, flow);
                }
                red = 0;
                green += 1;
                if (green > 255) green = 255;
            }
            return newBit;
        }

        public Bitmap block_mask()
        {
            Gray();
            int[,] mask = { { 0, -2, 0 }, 
                            { -2, 0, 2 }, 
                            { 0, 2, 0 } };
            int x, y;
            int r, c;
            int xPad = mask.GetLength(1) / 2;
            int yPad = mask.GetLength(0) / 2;
            double sum;
            Color sumColor;
            int[,] newBitArray = new int[bitmap.Width, bitmap.Height];
            double biasValue = 100.0;

            for(y=0; y < bitmap.Height - 2 * yPad; y++)// 핵심 
            {
                for(x=0; x<bitmap.Width - 2*xPad; x++)// 영상의 패드를 뺀모습
                {
                    sum = 0.0;
                    for (r = 0; r < mask.GetLength(0); r++)
                    {
                        for (c = 0; c < mask.GetLength(1); c++)
                        {
                            sum += colorArray[x + c,y + r]*mask[c,r];
                        }
                    }
                    sum = Math.Abs(sum);// 절대값으로 만들어줌
                    sum += biasValue; //마스크 결과값이 너무 낮아질때 명암을 올려줌
                    
                    if (sum > 255.0) sum = 255.0;
                    if (sum < 0.0) sum = 0.0;
                    newBitArray[x + xPad, y + yPad] = (int)sum;//저장은 한칸씩앞으로
                }
            }

            for(y=0; y<yPad; y++) // x라인 패딩
            {
                for (x = xPad; x < bitmap.Width - xPad; x++)
                {
                    newBitArray[x, y] = newBitArray[x, yPad];
                    newBitArray[x, bitmap.Height-1-y] = newBitArray[x, bitmap.Height-1-yPad];
                }
            }

            for (x = 0; x < xPad; x++) // y라인 패딩
            {
                for (y = yPad; y < bitmap.Height - yPad; y++)
                {
                    newBitArray[x, y] = newBitArray[xPad, y];
                    newBitArray[bitmap.Width - 1 - x, y] = newBitArray[bitmap.Width - 1 - xPad, y];
                }
            }

            for (y = 0; y < bitmap.Height; y++)// 비트맵으로 저장
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    sumColor = Color.FromArgb(newBitArray[x, y], newBitArray[x, y], newBitArray[x, y]);
                    newBit.SetPixel(x, y, sumColor);
                }
            }

            return newBit;
        }

        public Bitmap border()
        {
            int x, y;

            //가로
            for (y = 0; y < newBit.Height / 20; y++)
            {
                for (x = 0; x < newBit.Width; x++)
                {
                    newBit.SetPixel(x, y, Color.Black);
                    newBit.SetPixel(x, newBit.Height - y - 1, Color.Black);
                }
            }
            //세로
            for (y = 0; y < newBit.Height; y++)
            {
                for (x = 0; x < newBit.Width/20; x++)
                {
                    newBit.SetPixel(x, y, Color.Black);
                    newBit.SetPixel(newBit.Width - x -1, y, Color.Black);
                }
            }

            return newBit;
        }

        public Bitmap reverse()
        {
            Gray();
            int[,] reverse = new int[bitmap.Width, bitmap.Height];
            Color reColor;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    reColor = Color.FromArgb(255 - colorArray[x, y], 255 - colorArray[x, y], 255 - colorArray[x, y]);
                    newBit.SetPixel(x, y, reColor);
                }

            return newBit;
        }
        
    }
}
