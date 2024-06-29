using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cad3
{
    public class GetObject
    {
        [CommandMethod("GIL")]
        public void GetInforLineCad()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            Database db = doc.Database;

            PromptEntityOptions prOpt = new PromptEntityOptions("\nChon mot duong thang");
            prOpt.AllowNone = true;
            prOpt.AllowObjectOnLockedLayer = true;
            prOpt.SetRejectMessage("\nDoi tuong da chon khong la duong thang");
            prOpt.AddAllowedClass(typeof(Line), true);

            PromptEntityResult prResult = ed.GetEntity(prOpt);
            if (prResult.Status != PromptStatus.OK) return;

            Transaction trans = db.TransactionManager.StartTransaction();
            Line lineOb = trans.GetObject(prResult.ObjectId, OpenMode.ForRead) as Line;
            ed.WriteMessage("\nChieu dai cua duong thang vuaw chon la: " + Math.Round(lineOb.Length, db.Luprec, MidpointRounding.AwayFromZero));
            trans.Commit();


        }

        [CommandMethod("SS1")]
        public void GetSelection()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            Editor ed = doc.Editor;
            Database db = doc.Database;

            PromptSelectionOptions prSelop = new PromptSelectionOptions();
            prSelop.AllowDuplicates = false;
            prSelop.MessageForAdding = "\nChon duong thang de do chieu dai:";
            prSelop.MessageForRemoval = "\nChon duong thang de loai bo khoi danh sach chon";
            prSelop.RejectObjectsFromNonCurrentSpace = false;
            prSelop.RejectObjectsOnLockedLayers = true;
            prSelop.RejectPaperspaceViewport = true;


            TypedValue[] typeValue = new TypedValue[1];
            typeValue[0] = new TypedValue((int)DxfCode.Start, "LINE");
            SelectionFilter selFil = new SelectionFilter(typeValue);

            PromptSelectionResult prSelRe = ed.GetSelection(prSelop, selFil);
            if (prSelRe.Status != PromptStatus.OK) return;

            Transaction trans = db.TransactionManager.StartTransaction();
            try
            {
                SelectionSet selSet = prSelRe.Value;
                Line lineOb;
                double length = 0;
                foreach (SelectedObject line in selSet)
                {
                    lineOb = trans.GetObject(line.ObjectId, OpenMode.ForRead) as Line;
                    length += lineOb.Length;
                }

                ed.WriteMessage("tong chieu dai cac doan thang da chon la: " + Math.Round(length, db.Luprec, MidpointRounding.AwayFromZero));
            }
            catch (Autodesk.AutoCAD.Runtime.Exception ex)
            {
                Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("khong the tinh tong chieu dai duong line");


            }




        }

        [CommandMethod("Cvp")]
        public void CreatViewPort()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            //start transaction 
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                //open viewport table for read
                ViewportTable vptb;
                vptb = trans.GetObject(db.ViewportTableId, OpenMode.ForRead) as ViewportTable;

                //check to see if the named "Test viewport" exists
                if(vptb.Has("Viewport") == false)
                {
                    //open viewport table for write
                    trans.GetObject(db.ViewportTableId, OpenMode.ForWrite);
                    using(ViewportTableRecord vptbRec = new ViewportTableRecord())
                    {
                        vptb.Add(vptbRec);
                        trans.AddNewlyCreatedDBObject(vptbRec, true);

                        vptbRec.Name = "viewport 1";
                        vptbRec.LowerLeftCorner = new Point2d(0, 0);
                        vptbRec.UpperRightCorner = new Point2d(1, 0.5);


                    }
                }


                trans.Commit();
            }
        }
    }
}
