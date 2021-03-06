﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;
using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCarManagement.Data
{
    public class ExportPdf
    {

        public static void ExportToPdf(DataTable dt, string filepath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"{filepath}", FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12);
            iTextSharp.text.Font fontHeader = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 20);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            //float[] widths = new float[] { 4f, 4f};

            //table.SetWidths(widths);
            table.HorizontalAlignment = 0;
            table.WidthPercentage = 100;

            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase((dt.TableName), fontHeader));
            cell.Colspan = dt.Rows.Count;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {

                table.AddCell(new Phrase(c.ColumnName, font5));
            }
            
            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(r[i].ToString(), font5));
                    };
                    
                }
            }
            document.Add(table);
            document.Close();
        }

        public static void ExportToPdfQuer(DataTable dt, string filepath)
        {
            Document document = new Document();
            document.SetPageSize(PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"{filepath}", FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12);
            iTextSharp.text.Font fontHeader = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 20);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            
            PdfPRow row = null;
            //float[] widths = new float[] { 4f, 4f};

            //table.SetWidths(widths);
            table.HorizontalAlignment = 0;
            table.WidthPercentage = 100;

            
            PdfPCell cell = new PdfPCell(new Phrase((dt.TableName), fontHeader));
            cell.Colspan = dt.Columns.Count;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {

                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(r[i].ToString(), font5));
                    };

                }
            }
            document.Add(table);
            document.Close();
        }

        public static void ExportToPdfQuerMitPic(List<Rent> rents, string filepath, NpgsqlConnection connection)
        {
            Document document = new Document();
            document.SetPageSize(PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"{filepath}", FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12);
            iTextSharp.text.Font fontHeader = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 20);

            PdfPTable table = new PdfPTable(8);

            PdfPRow row = null;
            
            table.HorizontalAlignment = 0;
            table.WidthPercentage = 100;


            PdfPCell cell = new PdfPCell(new Phrase(("Vermietungen"), fontHeader));
            cell.Colspan = 8;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell.Colspan = 8;

            iTextSharp.text.Image image = null;

            foreach (Rent r in rents)
            {
                
                if (rents.Count > 0)
                {
                    System.Drawing.Image pic = ImageCar.GetMainImage(connection, r.CarId);
                    if (pic != null)
                    {
                        image = iTextSharp.text.Image.GetInstance(pic, ImageFormat.Jpeg);
                        PdfPCell imageCell = new PdfPCell(image);
                        imageCell.Colspan = 1;
                        imageCell.Border = 0;
                        table.AddCell(image);
                    }
                    else
                    {
                        table.AddCell(new Phrase("", font5));

                    }


                    table.AddCell(new Phrase(r.RentNo, font5));
                    

                }
            }
            document.Add(table);
            document.Close();
        }
    }
}
