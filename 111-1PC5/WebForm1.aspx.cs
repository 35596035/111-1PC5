using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] i_Num = new int[3, 3]
            {
                {7,8,9 },
                {1,4,3 },
                {2,5,6 }
            };

            int[] i_CtNum = new int[19] {
                10000,36,720,360,80,
                252,108,72,54,180,
                72,180,119,36,306,
                1080,144,1800,3600
            };

            Response.Write("可以獲得最多的錢是" + mt_GetMost(i_Num, i_CtNum));
            Response.Write("<br>");
            Response.Write("可以獲得最少的錢是" + mt_GetLeast(i_Num, i_CtNum));
        }
        int mt_GetMost(int[,] i_Num, int[] i_CtNum)
        {
            int i_Max = 0;

            for (int i_Row = 0; i_Row < i_Num.GetLength(0); i_Row++)
            {
                int i_Rsum = 0;
                int i_Csum = 0;
                for (int i_Col = 0; i_Col < i_Num.GetLength(1); i_Col++)
                {
                    i_Rsum += i_Num[i_Row, i_Col];
                    i_Csum += i_Num[i_Col, i_Row];
                }
                // Response.Write((i_Rsum, i_Csum).ToString()); Test

                if (i_CtNum[i_Rsum - 6] > i_CtNum[i_Csum - 6])
                {
                    if (i_CtNum[i_Rsum - 6] > i_Max)
                    {
                        i_Max = i_CtNum[i_Rsum - 6];
                    }
                }
                else
                {
                    if (i_CtNum[i_Csum - 6] > i_Max)
                    {
                        i_Max = i_CtNum[i_Csum - 6];
                    }
                }
            }

            int i_Slash1 = i_Num[0, 0] + i_Num[1, 1] + i_Num[2, 2];
            if (i_CtNum[i_Slash1 - 6] > i_Max)
            {
                i_Max = i_CtNum[i_Slash1 - 6];
            }
            //Response.Write((i_Slash1).ToString()); Test

            int i_Slash2 = i_Num[0, 2] + i_Num[1, 1] + i_Num[2, 0];
            if (i_CtNum[i_Slash2 - 6] > i_Max)
            {
                i_Max = i_CtNum[i_Slash2 - 6];
            }
            //Response.Write((i_Slash2).ToString()); Test
            return i_Max;
        }
        int mt_GetLeast(int[,] i_Num, int[] i_CtNum)
        {
            int i_Min = 10001;

            for (int i_Row = 0; i_Row < i_Num.GetLength(0); i_Row++)
            {
                int i_Rsum = 0;
                int i_Csum = 0;
                for (int i_Col = 0; i_Col < i_Num.GetLength(1); i_Col++)
                {
                    i_Rsum += i_Num[i_Row, i_Col];
                    i_Csum += i_Num[i_Col, i_Row];
                }
                //Response.Write((i_Rsum, i_Csum).ToString()); Test

                if (i_CtNum[i_Rsum - 6] < i_CtNum[i_Csum - 6])
                {
                    if (i_CtNum[i_Rsum - 6] < i_Min)
                    {
                        i_Min = i_CtNum[i_Rsum - 6];
                    }
                }
                else
                {
                    if (i_CtNum[i_Csum - 6] < i_Min)
                    {
                        i_Min = i_CtNum[i_Csum - 6];
                    }
                }
            }

            int i_Slash1 = i_Num[0, 0] + i_Num[1, 1] + i_Num[2, 2];
            if (i_CtNum[i_Slash1 - 6] < i_Min)
            {
                i_Min = i_CtNum[i_Slash1 - 6];
            }
            //Response.Write((i_Slash1).ToString()); Test

            int i_Slash2 = i_Num[0, 2] + i_Num[1, 1] + i_Num[2, 0];
            if (i_CtNum[i_Slash2 - 6] < i_Min)
            {
                i_Min = i_CtNum[i_Slash2 - 6];
            }
            //Response.Write((i_Slash2).ToString()); Test
            return i_Min;
        }
    }
}