using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OgrenciInfo ogr = new OgrenciInfo();
            rptOgrenciler.DataSource = ogr.OgrenciListesi().OrderBy(x => x.Adi);
            rptOgrenciler.DataBind();
        }
    }


    protected void btnExportDatatoExcel_OnClick(object sender, EventArgs e)
    {
        string dosyaAdi = "Öğrenci Listesi.xls";

        OgrenciInfo ogr = new OgrenciInfo();
        List<OgrenciInfo> ogrenci = ogr.OgrenciListesi().OrderBy(x => x.Adi).ToList();

        StringBuilder sb = new StringBuilder(); //StringBuilder metin birleştirme sınıfı

        sb.Append("<table border = '1'>");
        sb.Append("<tr><th style='text-align: center;padding: 18px;font-size: 25px;font-weight: bold;' colspan='6'>KURTULUŞ ORTAOKULU</th></tr>");
        sb.Append("<tr>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Sıra No</th>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Adı</th>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Soyadı</th>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Cinsiyet</th>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Sınıf</th>");
        sb.Append("<th style='background-color: #4CAF50;color:#FFFFFF'>Numarası</th>");
        sb.Append("</tr>");

        for (int i = 0; i < ogrenci.Count; i++)
        {
            sb.Append("<tr>");
            sb.Append("<td>" + i + 1 + "</td>");
            sb.Append("<td>" + ogrenci[i].Adi + "</td>");
            sb.Append("<td>" + ogrenci[i].Soyadi + "</td>");
            sb.Append("<td>" + ogrenci[i].Cinsiyeti + "</td>");
            sb.Append("<td>" + ogrenci[i].Sinifi + "</td>");
            sb.Append("<td>" + ogrenci[i].Numarasi + "</td>");
            sb.Append("</tr>");
        }

        sb.Append("</table>");

        Response.Clear();
        Response.Buffer = true; //Tüm veriler yüklenmesi bitmeden Browser'e gönderilmesini engelle. 
        Response.AddHeader("content-disposition", "attachment;filename=" + dosyaAdi);
        Response.ContentEncoding = Encoding.GetEncoding("ISO-8859-9"); //Türkçe karakter sorunu için 
        Response.Charset = "ISO-8859-9";
        Response.ContentType = "application/vnd.ms-excel";

        Response.Output.Write(sb.ToString());

        Response.Flush(); //tutulan verileri boşalt.
        Response.End(); 
    }
}