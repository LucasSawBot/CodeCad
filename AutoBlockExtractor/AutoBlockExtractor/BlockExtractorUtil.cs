using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace AutoBlockExtractor
{
    public class BlockExtractorUtil
    {
        [CommandMethod("EB")]
        public void ExtractBlock()
        {
            BlockExtractorForm form = new BlockExtractorForm();
            form.Show();
        }
        internal void ProcessBlockExtraction(string dwgFile, string blockName, string fileName)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            doc.LockDocument();

            //get the database and editor object
            Database db = doc.Database;
            Editor ed = doc.Editor;

            ed.WriteMessage("\nSelecting all the " + blockName + "in the drawing");
            using(Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;

                if (bt.Has(blockName))
                {
                    ed.WriteMessage("khong tim thay block trong ban ve");
                    return;
                }

                //create a type value foe the selection filter
                TypedValue[] tv = new TypedValue[2];
                tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                tv.SetValue(new TypedValue((int)DxfCode.BlockName, blockName), 1);

                //create a filter with these values
                SelectionFilter filter = new SelectionFilter(tv);
                PromptSelectionResult psr = ed.SelectAll(filter);

                //check if there is object selected
                if (psr.Status == PromptStatus.OK)
                {
                    SelectionSet ss = psr.Value;
                    string attrVal = "";
                    string header = "";

                    StreamWriter writer = new StreamWriter(fileName);

                    //construct the header by looping through the list of attributrs of a block
                    SelectedObject selObj = ss[0];
                    BlockReference bref = trans.GetObject(selObj.ObjectId, OpenMode.ForWrite) as BlockReference;
                    if (bref.AttributeCollection.Count > 0)
                    {
                        header = "insert x, insert Y";
                        foreach(ObjectId attReffId in bref.AttributeCollection)
                        {
                            DBObject obj = trans.GetObject(attReffId, OpenMode.ForRead);
                            AttributeReference attRef = obj as AttributeReference;
                            if (attRef != null)
                            {
                                header += attRef.Tag + ",";
                            }
                            writer.WriteLine(header.Substring(0, header.Length - 1));
                        }
                    }

                    //Loop through the selction set  and extract the block attribute values
                    foreach (SelectedObject sobj in ss)
                    {
                        BlockReference br = trans.GetObject(sobj.ObjectId, OpenMode.ForWrite) as BlockReference;
                        if(br.AttributeCollection.Count > 0)
                        {
                            //get the intersection points
                            attrVal += br.Position.X.ToString() + "," + br.Position.Y.ToString();
                            foreach(ObjectId attReferenceId in br.AttributeCollection)
                            {
                                DBObject obj = trans.GetObject(attReferenceId, OpenMode.ForRead);
                                AttributeReference attRef = obj as AttributeReference;
                                if (attRef !=null)
                                {
                                    attrVal += attRef.TextString + ",";

                                }
                            }
                            writer.WriteLine(attrVal.Substring(0, attrVal.Length - 1));
                            attrVal = "";


                        }
                    }

                    //display the count of the block selected
                    ed.WriteMessage("Number of " + blockName + "found is: " + ss.Count.ToString());
                    writer.Close();

                }
                else
                {
                    ed.WriteMessage("there is no Block found");
                }

            }
            doc.CloseAndDiscard();

        }
        

    }
}
