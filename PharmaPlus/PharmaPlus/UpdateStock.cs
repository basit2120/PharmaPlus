using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaPlus
{
    class UpdateStock
    {
        string ItemName;
        int ItemQuantity;
        int PricePerPiece;
        string ItemType;
        float Milligram;
        string MLNumber;
        string ManufacturedBy;
        DateTime DateAdded;

        public string ItemName1 { get => ItemName; set => ItemName = value; }
        public int ItemQuantity1 { get => ItemQuantity; set => ItemQuantity = value; }
        public int PricePerPiece1 { get => PricePerPiece; set => PricePerPiece = value; }
        public string ItemType1 { get => ItemType; set => ItemType = value; }
        public float Milligram1 { get => Milligram; set => Milligram = value; }
        public string ManufacturedBy1 { get => ManufacturedBy; set => ManufacturedBy = value; }
        public DateTime DateAdded1 { get => DateAdded; set => DateAdded = value; }
        public string MLNumber1 { get => MLNumber; set => MLNumber = value; }
    }
}
