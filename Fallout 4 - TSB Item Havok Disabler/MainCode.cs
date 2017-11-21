using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Fallout_4___TSB_Item_Havok_Disabler_MainCode
{

    public class Header
    {
        public string export_date { get; set; }
        public int item_count { get; set; }
        public string player_name { get; set; }
        public double plugin_version { get; set; }
        public List<string> plugins_required { get; set; }
        public string settlement_name { get; set; }
        public string worldspace_id { get; set; }
        public int worldspace_id_dec { get; set; }
        public string worldspace_name { get; set; }
        public string worldspace_plugin { get; set; }
    }

    public class Item
    {
        public string ConnectedObjects { get; set; }
        public string ExtraData { get; set; }
        public string FormID { get; set; }
        public int FormID_dec { get; set; }

        //To make a property optional, make a bool function with a specific name: "ShouldSieralize" + NameOfTheProperty

        public int PlotPath01FormID_dec { get; set; }
        public bool ShouldSerializePlotPath01FormID_dec()
        {
            return (PlotPath01FormID_dec != 0  && PlotPath01Plugin != "");
        }
        public string PlotPath01Plugin { get; set; }
        public bool ShouldSerializePlotPath01Plugin()
        {
            return (PlotPath01Plugin != null && PlotPath01Plugin != "");
        }
        public int PlotPath02FormID_dec { get; set; }
        public bool ShouldSerializePlotPath02FormID_dec()
        {
            return (PlotPath02FormID_dec != 0 && PlotPath01Plugin != "");
        }
        public string PlotPath02Plugin { get; set; }
        public bool ShouldSerializePlotPath02Plugin()
        {
            return (PlotPath02Plugin != null && PlotPath01Plugin != "");
        }
        public int PlotPath03FormID_dec { get; set; }
        public bool ShouldSerializePlotPath03FormID_dec()
        {
            return (PlotPath03FormID_dec != 0 && PlotPath01Plugin != "");
        }
        public string PlotPath03Plugin { get; set; }
        public bool ShouldSerializePlotPath03Plugin()
        {
            return (PlotPath03Plugin != null && PlotPath01Plugin != "");
        }
        public string PlotPlanFormID { get; set; }
        public bool ShouldSerializePlotPlanFormID()
        {
            return (PlotPlanFormID != null && PlotPath01Plugin != "");
        }
        public int PlotPlanFormID_dec { get; set; }
        public bool ShouldSerializePlotPlanFormID_dec()
        {
            return (PlotPlanFormID_dec != 0 && PlotPath01Plugin != "");
        }
        public string PlotPlanPlugin { get; set; }
        public bool ShouldSerializePlotPlanPlugin()
        {
            return (PlotPlanPlugin != null && PlotPath01Plugin != "");
        }
        public int PlotStage { get; set; }
        public bool ShouldSerializPlotStage()
        {
            return (PlotStage != 0 && PlotPath01Plugin != "");
        }
        public int PlotVIPStoryFormID_dec { get; set; }
        public bool ShouldSerializePlotVIPStoryFormID_dec()
        {
            return (PlotVIPStoryFormID_dec != 0 && PlotPath01Plugin != "");
        }
        public string PlotVIPStoryPlugin { get; set; }
        public bool ShouldSerializePlotVIPStoryPlugin()
        {
            return (PlotVIPStoryPlugin != null && PlotPath01Plugin != "");
        }
        public int RemoveHavok { get; set; }
        public double Scale { get; set; }
        public int idx { get; set; }
        public int isActor { get; set; }
        public int isCreated { get; set; }
        public int isFarmAnimal { get; set; }
        public int isGenerator { get; set; }
        public int isPowered { get; set; }
        public int isTamedCreature { get; set; }
        public int isTurret { get; set; }
        public string name { get; set; }
        public string plugin_name { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }
        public double posZ { get; set; }
        public double rotX { get; set; }
        public double rotY { get; set; }
        public double rotZ { get; set; }
    }

    public class Workshop
    {
        public int baseid_dec { get; set; }
        public string id { get; set; }
        public int id_dec { get; set; }
        public string plugin { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }
        public double posZ { get; set; }
        public double rotX { get; set; }
        public double rotY { get; set; }
        public double rotZ { get; set; }
    }

    public class RootObject
    {
        public Header header { get; set; }
        public List<Item> items { get; set; }
        public Workshop workshop { get; set; }
    }

    public class MainCode
    {
        public static void ProcessBlueprint(string strBlueprintPath)
        {
            RootObject JSONBlueprint = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(strBlueprintPath));


            string strProgramPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\TSB";
            HashSet<string> strsetFallout4 = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - Fallout4.txt"));
            HashSet<string> strsetDLCRobot = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - DLCRobot.txt"));
            HashSet<string> strsetDLCWorkshop01 = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - DLCworkshop01.txt"));
            HashSet<string> strsetDLCWorkshop02 = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - DLCworkshop02.txt"));
            HashSet<string> strsetDLCWorkshop03 = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - DLCworkshop03.txt"));
            HashSet<string> strsetDLCNukaWorld = new HashSet<string>(File.ReadAllLines(strProgramPath + "\\Items - DLCNukaWorld.txt"));

            foreach (Item itemCurrent in JSONBlueprint.items)
            {

                if ( (itemCurrent.plugin_name == "Fallout4.esm") && (strsetFallout4.Contains(itemCurrent.FormID_dec.ToString())) )
                {
                    itemCurrent.RemoveHavok = 1;
                }

                if ((itemCurrent.plugin_name == "DLCRobot.esm") && (strsetDLCRobot.Contains(itemCurrent.FormID_dec.ToString())))
                {
                    itemCurrent.RemoveHavok = 1;
                }

                if ((itemCurrent.plugin_name == "DLCworkshop01.esm") && (strsetDLCWorkshop01.Contains(itemCurrent.FormID_dec.ToString())))
                {
                    itemCurrent.RemoveHavok = 1;
                }

                if ((itemCurrent.plugin_name == "DLCworkshop02.esm") && (strsetDLCWorkshop02.Contains(itemCurrent.FormID_dec.ToString())))
                {
                    itemCurrent.RemoveHavok = 1;
                }

                if ((itemCurrent.plugin_name == "DLCworkshop03.esm") && (strsetDLCWorkshop03.Contains(itemCurrent.FormID_dec.ToString())))
                {
                    itemCurrent.RemoveHavok = 1;
                }

                if ((itemCurrent.plugin_name == "DLCNukaWorld.esm") && (strsetDLCNukaWorld.Contains(itemCurrent.FormID_dec.ToString())))
                {
                    itemCurrent.RemoveHavok = 1;
                }

            using (StreamWriter fileOutput = File.CreateText(strBlueprintPath.Remove(strBlueprintPath.Length - 5) + "_HavokDisabled.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(fileOutput, JSONBlueprint);
            }

            }

        }

    }
}
