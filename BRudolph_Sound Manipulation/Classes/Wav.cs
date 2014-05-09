using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRudolph_Sound_Manipulation.Classes
{
    public class Wav
    {
        public byte[] RIFFBytes { get; private set; }
        public byte[] FmtBytes { get; private set; }
        public byte[] DataBytes { get; private set; }
        public byte[] WavBytes { get; private set; }

        public Wav(string filePath)
        {
            setFilePath(filePath);
        }

        public void setFilePath(string filePath)
        {
            System.IO.FileStream wavStream = System.IO.File.OpenRead(@filePath);
            byte[] RIFFBytes = new byte[wavStream.Length];
            byte[] FmtBytes = new byte[wavStream.Length];
            byte[] DataBytes = new byte[wavStream.Length];
            byte[] WavBytes = new byte[wavStream.Length];
            wavStream.Read(RIFFBytes, 0, 12);
            wavStream.Read(FmtBytes, 12, 24);
            wavStream.Read(DataBytes, 36, 8);
            wavStream.Read(WavBytes, 44, (WavBytes.Length - 44));
        }

        public string getByteString()
        {
            string byteString = "";

            for (int i = 0; i < 1000; i++)
            {
                byteString += WavBytes[i] + " ";
            }

            return byteString;
        }
    }
}