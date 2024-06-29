using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System.Collections;

namespace ControlDemo
{
    public class ControlsDemoUtils
    {

        [CommandMethod("Demo")]
        public void Demo()
        {
            MainForm mf = new MainForm();
            mf.Show();
        }

        public ArrayList GetLayer()
        {
            ArrayList layers = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LayerTable lyTab = trans.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (var ly in lyTab)
                {
                    LayerTableRecord lyTr = trans.GetObject(ly, OpenMode.ForRead) as LayerTableRecord;
                    layers.Add(lyTr.Name);

                }
            }

            return layers;
        }

        public ArrayList GetLineType()
        {
            ArrayList linetypes = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LinetypeTable ltTab = trans.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;
                foreach (var lt in ltTab)
                {
                    LinetypeTableRecord ltTr = trans.GetObject(lt, OpenMode.ForRead) as LinetypeTableRecord;
                    linetypes.Add(ltTr.Name);

                }
            }

            return linetypes;
        }

        public ArrayList GetTextstyle()
        {
            ArrayList textStyles = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                TextStyleTable stTab = trans.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                foreach (var st in stTab)
                {
                    TextStyleTableRecord stTr = trans.GetObject(st, OpenMode.ForRead) as TextStyleTableRecord;
                    textStyles.Add(stTr.Name);

                }
            }

            return textStyles;
        }

    }
}
