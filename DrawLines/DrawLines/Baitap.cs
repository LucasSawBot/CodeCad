using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;



namespace DrawLines
{
    public class Baitap
    {
        [CommandMethod("lenh1")]
        public void VeDoanthang()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            
            Point3d p1;
            Point3d p2;
            Point3d p3;


            PromptPointOptions po = new PromptPointOptions("\nChon mot diem");
            PromptPointResult pr1 = ed.GetPoint(po);
            if(pr1.Status == PromptStatus.OK)
            {
                p1 = pr1.Value;
            }

            PromptPointResult pr2 = ed.GetPoint(po);
            if (pr2.Status == PromptStatus.OK)
            {
                p2 = pr2.Value;
            }

            PromptPointResult pr3 = ed.GetPoint(po);
            if (pr3.Status == PromptStatus.OK)
            {
                p3 = pr3.Value;
            }

            ed.WriteMessage("Diem 1: " + p1.ToString() + "Diem 2: " + p2.ToString() + "Diem 3: " + p3.ToString());

        }
    }
}
