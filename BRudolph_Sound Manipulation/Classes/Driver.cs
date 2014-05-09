using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRudolph_Sound_Manipulation.Classes
{
    public class Driver
    {
        public MainWindow mainWindow { get; private set; }
        public Composite composite { get; private set; }

        public Driver(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            composite = new Composite();
        }

        public void run()
        {
            Wav wav = new Wav();
            wav.setFilePath("C:\\Users\\brudolph\\Dropbox\\Old School Files\\Capstone\\Sample wav\\Jazz_Funk_Rock_samples1\\ANIT12956.wav");
            byte[] wavBytes = wav.WavBytes;

            string wavString = wav.getByteString();

            mainWindow.changeText(wavString);
        }

        public void openFile(string fileName)
        {
            composite.Layers.Add(new Wav(fileName));
        }

        public void saveFile(string fileName)
        {
            composite.Layers.Add(new Wav(fileName));
        }
    }
}