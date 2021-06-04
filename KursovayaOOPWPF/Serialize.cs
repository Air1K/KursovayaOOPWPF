using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Block
    {
        public List<Toys> game = new List<Toys>();
        public List<BakeryProducts> Bakery = new List<BakeryProducts>();
        public List<Seafood> Seaf = new List<Seafood>();
        public List<Alcohol> Alco = new List<Alcohol>();
        public List<Juices> Juic = new List<Juices>();
    }

    public class Serialize
    {

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        Block CaptureBlock(Block Temp)
        {
            Temp.game = DB.game;
            Temp.Bakery = DB.Bakery;
            Temp.Seaf = DB.Seaf;
            Temp.Alco = DB.Alco;
            Temp.Juic = DB.Juic;
            return Temp;
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, CaptureBlock(new Block()));
            }
        }

        Block GetDeserializedBlock()
        {
            Block DeserializeBlock;
            using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
            {
                DeserializeBlock = binaryFormatter.Deserialize(fileStream) as Block;
            }
            return DeserializeBlock;
        }

        void SetDB(Block loadBlock)
        {
            DB.game = loadBlock.game;
            DB.Bakery = loadBlock.Bakery;
            DB.Seaf = loadBlock.Seaf;
            DB.Alco = loadBlock.Alco;
            DB.Juic = loadBlock.Juic;
        }

        public void Load()
        {
            SetDB(GetDeserializedBlock());
        }

    }
}
