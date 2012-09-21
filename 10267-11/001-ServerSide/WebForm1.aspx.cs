﻿using System;
using System.Collections.Generic;

namespace _001_ServerSide
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        protected void Timer1Tick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            var lista = new List<String> { "selecione uma opção", "solteiro", "casado", "divorciado", "viúvo", "outro"};

            DropDownList1.DataSource = lista;
            DropDownList1.DataBind();

            System.Threading.Thread.Sleep(1000);

            DropDownList1.Visible = true;
            Button1.Visible = false;
        }
    }
}