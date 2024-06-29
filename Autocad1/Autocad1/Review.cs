using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System.Windows.Forms;
using acad = Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Geometry;

namespace Enesy
{
    public class Review
    {
        [CommandMethod("GBL")]
        public void GetAllBlockTableRecord()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                BlockTable bl = doc.Database.BlockTableId.GetObject(OpenMode.ForRead) as BlockTable;

                foreach (ObjectId obj in bl)
                {
                    BlockTableRecord blr = obj.GetObject(OpenMode.ForRead) as BlockTableRecord;
                    MessageBox.Show(blr.Name);
                }


            }


        }

        //Tao moi 1 BLocktableRecord

        [CommandMethod("NBL")]
        public void NewBlockTableRecord()
        {
            Document doc = acad.Application.DocumentManager.MdiActiveDocument;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                //lay ra blocktable
                BlockTable bl = doc.Database.BlockTableId.GetObject(OpenMode.ForWrite) as BlockTable;

                //tao moi mot BlocktableRecord
                BlockTableRecord newblr = new BlockTableRecord();
                newblr.Name = "MyCircle";

                //them vao Blocktable
                bl.Add(newblr);

                //them vao transaction
                tr.AddNewlyCreatedDBObject(newblr, true);

                //commit
                tr.Commit();


            }
        }

        //Lay ra BlockTablerecord thong qua ten cua no
        [CommandMethod("GetBL")]
        public void GetBlockTabkeRecord()
        {
            acad.Document doc = acad.Application.DocumentManager.MdiActiveDocument;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                //lay ra BlockTable
                BlockTable bl = doc.Database.BlockTableId.GetObject(OpenMode.ForRead) as BlockTable;

                //lay ra BlockTableRecord co ten "MyCircle"
                BlockTableRecord myBlr = tr.GetObject(bl["MyCircle"], OpenMode.ForWrite) as BlockTableRecord;

                //Them doi tuong vao MyCircle Block
                Circle c = new Circle(new Point3d(0, 0, 0), Vector3d.ZAxis, 10);
                myBlr.AppendEntity(c);

                tr.AddNewlyCreatedDBObject(c, true);

                tr.Commit();


            }
        }
    }
}
