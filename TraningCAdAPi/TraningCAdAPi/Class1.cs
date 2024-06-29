using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraningCAdAPi
{
    public class Class1
    {
        [CommandMethod("Testcmd")]
        public void Test()
        {
            
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            using(Transaction tr = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                if(bt != null)
                {
                    var ms = tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    Circle circle = new Autodesk.AutoCAD.DatabaseServices.Circle();
                    Random ran = new Random();
                    int c = ran.Next();
                    circle.Center = new Autodesk.AutoCAD.Geometry.Point3d(0, 10, 0);
                    circle.Radius = c;
                    ms?.AppendEntity(circle);
                    tr.AddNewlyCreatedDBObject(circle, true);
                }
                tr.Commit();
            }
            
        }
    }
}
