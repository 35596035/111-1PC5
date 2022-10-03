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
            int[,] ia_2DArr = new int[2, 3]
            {
                { 7, 8, 9},
                { 1, 4, 3},
            };
            Response.Write(ia_2DArr.GetLength(0));
            Response.Write(ia_2DArr.GetLength(1));
        }
    }
}