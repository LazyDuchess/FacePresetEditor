using S3.CAS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FacePresetEditor.Formats
{
    class XMLFile
    {
        public static void Deserialize(string file, FacePresetWrapper facePreset)
        {
            var reader = new XmlTextReader(file);
            FaceBlendValue fVal = null;  
            var element = "";
            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        
                        Debug.WriteLine(reader.Name + " is element");
                        element = reader.Name;
                        if (element == "FaceBlend")
                        {
                            fVal = new FaceBlendValue();
                            fVal.faceBlendTGI = new S3.Common.TGI();
                            facePreset.facePreset.faceBlends.Add(fVal);
                        }
                        break;
                    case XmlNodeType.Text:
                        Debug.WriteLine(reader.Value + " is text");
                        if (element == "Amount")
                            fVal.amount = float.Parse(reader.Value);
                        if (element == "Instance")
                            fVal.faceBlendTGI.instance = ulong.Parse(reader.Value);
                        if (element == "Group")
                            fVal.faceBlendTGI.group = uint.Parse(reader.Value);
                        if (element == "Type")
                            fVal.faceBlendTGI.type = uint.Parse(reader.Value);
                        if (element == "Name")
                        {
                            if (fVal == null)
                                facePreset.facePreset.name = reader.Value;
                            else
                            {
                                var elm = new FaceBlendValueMetadata();
                                elm.name = reader.Value;
                                facePreset.faceBlendMetadata.Add(elm);
                            }
                        }
                        if (element == "Region")
                        {
                            switch(reader.Value)
                            {
                                case "Head":
                                    facePreset.facePreset.presetType = PresetType.Face;
                                    break;
                                case "Eyes":
                                    facePreset.facePreset.presetType = PresetType.Eyes;
                                    break;
                                case "Nose":
                                    facePreset.facePreset.presetType = PresetType.Nose;
                                    break;
                                case "Mouth":
                                    facePreset.facePreset.presetType = PresetType.Mouth;
                                    break;
                            }
                        }
                        break;
                    case XmlNodeType.CDATA:
                        Debug.WriteLine(reader.Value + " is cdata");
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Debug.WriteLine(reader.Name + " is " + reader.Value + "(Processing instruction)");
                        break;
                    case XmlNodeType.Comment:
                        Debug.WriteLine(reader.Value + " is comment");
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Debug.WriteLine("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Debug.WriteLine("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Debug.WriteLine(reader.Name + " is entity reference");
                        break;
                    case XmlNodeType.EndElement:
                        Debug.WriteLine(reader.Name + " is end element");
                        element = "";
                        if (element == "FaceBlend")
                            fVal = null;
                        break;
                }
            }
            reader.Close();
            reader.Dispose();
        }
    }
}
