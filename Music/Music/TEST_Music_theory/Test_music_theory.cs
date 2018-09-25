using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicTheory;
using System.Collections.Generic;

namespace TEST_Music_theory
{
    [TestClass]
    public class Test_music_theory
    {
        string[] CMajor = new string[7]{"C","D","E","F","G","A","B"};
        string[] BdoubleFlatMajor = new string[7] { "Bbb", "Cb", "Db", "Ebb", "Fb", "Gb", "Ab" };
        string[] DDorian = new string[7] { "D", "E", "F", "G", "A", "B", "C" };
        string[] EDorian = new string[7] {"E", "F#", "G", "A", "B", "C#","D" };
        string[] GDorian = new string[7] {"G", "A", "Bb", "C", "D","E","F" };
        string[] EPhrygian = new string[7] { "E", "F", "G", "A", "B", "C", "D" };
        string[] Flydian = new string[7] { "F", "G", "A", "B", "C", "D", "E" };
        string[] Mixolydian = new string[7] { "G", "A", "B", "C", "D", "E", "F" };
        string[] AAeolian = new string[7] { "A", "B", "C", "D", "E", "F", "G" };
        string[] BLocrian = new string[7] { "B", "C", "D", "E", "F", "G", "A" };
        string[] CPentatonicMajor = new string[5] { "C", "D", "E", "G", "A" };
        string[] APentatonicMinor = new string[5] { "A", "C", "D", "E", "G" };
        string[] C_jsen = new string[5] { "C", "Db", "F", "G", "Bb" };
        string[] C_jHirajoshi = new string[5] { "C", "Db", "F", "G", "Ab" };
        string[] C_minor_natural = new string[7] { "C", "D", "Eb", "F", "G", "Ab", "Bb" };
        string[] C_minor_Harmonic = new string[7] { "C", "D", "Eb", "F", "G", "Ab", "B" };
        string[] D_melodic_minor = new string[15] { "D", "E", "F", "G", "A", "B", "C#", "D", "C", "Bb", "A", "G", "F", "E", "D" };
        string[] A_Pentatonic_melodic = new string[5] { "A", "B", "C", "E", "F#" };
        string[] C_bobop_mixolydian = new string[8] { "C", "D", "E", "F", "G", "A", "Bb", "B" };
        string[] D_bebop_dorian = new string[8] { "D", "E", "F", "F#", "G", "A", "B", "C" };
        string[] G_chord_major = new string[7] { "G", "B", "D", "F#", "A", "C", "E" };
        string[] A_chord_minor = new string[7] { "A", "C", "E", "G", "B", "D", "F" };
        string[] C_Spanish_scale = new string[8] { "C", "Db", "E", "F", "G", "Ab", "Bb", "C" };

        [TestMethod]
        public void TestMethod1()
        {
            MajorScale C = new MajorScale();
            C.GetNotesInMajorScale("C");
            Assert.AreEqual(C.root, "C");
        }
        [TestMethod]
        public void CmajorScale()
        {
            List<Note> temp = new List<Note>();
            MajorScale C = new MajorScale();
            temp = C.GetNotesInMajorScale("C");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, CMajor[i]);
            }
        }
        [TestMethod]
        public void BdoulbeFlatmajorScale()
        {
            List<Note> temp = new List<Note>();
            MajorScale Bbb = new MajorScale();
            temp = Bbb.GetNotesInMajorScale("Bbb");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, BdoubleFlatMajor[i]);
            }
        }
        [TestMethod]
        public void DDorianMode()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Dorian("D");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, DDorian[i]);
            }
        }
        [TestMethod]
        public void EDorianMode()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Dorian("E");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, EDorian[i]);
            }
        }
        [TestMethod]
        public void GDorianMode()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Dorian("G");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, GDorian[i]);
            }
        }
        [TestMethod]
        public void EPhrygianMode()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Phrygian("E");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, EPhrygian[i]);
            }
        }
        [TestMethod]
        public void FLydianMode()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Lydian("F");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, Flydian[i]);
            }
        }
        [TestMethod]
        public void GMixolydian()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Mixolydian("G");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, Mixolydian[i]);
            }
        }
        [TestMethod]
        public void Aaeolian()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Aeolian("A");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, AAeolian[i]);
            }
        }
        [TestMethod]
        public void Blocrian()
        {
            Mode mode = new Mode();
            List<Note> temp = new List<Note>();
            temp = mode.Locrian("B");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, BLocrian[i]);
            }
        }
        [TestMethod]
        public void CpentatonicMajor()
        {
            Pentatonic pentatonic = new Pentatonic();
            List<Note> temp = new List<Note>();
            temp = pentatonic.Major("C");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(temp[i].name, CPentatonicMajor[i]);
            }
        }
        [TestMethod]
        public void ApentatonicMinor()
        {
            Pentatonic pentatonic = new Pentatonic();
            List<Note> temp = new List<Note>();
            temp = pentatonic.Minor("A");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(temp[i].name, APentatonicMinor[i]);
            }
        }
        [TestMethod]
        public void pentatonicSen()
        {
            Pentatonic pentatonic = new Pentatonic();
            List<Note> temp = new List<Note>();
            temp = pentatonic.Sen("C");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(temp[i].name, C_jsen[i]);
            }
        }
        [TestMethod]
        public void pentatonic_hirajoshi()
        {
            Pentatonic pentatonic = new Pentatonic();
            List<Note> temp = new List<Note>();
            temp = pentatonic.Hirajoshi("C");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(temp[i].name, C_jHirajoshi[i]);
            }
        }
        [TestMethod]
        public void CminorNatural()
        {
            MinorScale minor = new MinorScale();
            List<Note> temp = new List<Note>();
            temp = minor.Natural("C");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, C_minor_natural[i]);
            }
        }
        [TestMethod]
        public void CminorHarmonic()
        {
            MinorScale minor = new MinorScale();
            List<Note> temp = new List<Note>();
            temp = minor.Harmonic("C");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(temp[i].name, C_minor_Harmonic[i]);
            }
        }
        [TestMethod]
        public void D_Minor_melodic()
        {
            MinorScale minor = new MinorScale();
            List<Note> temp = new List<Note>();
            temp = minor.Melodic("D");
            for (int i = 0; i < 15; i++)
            {
                Assert.AreEqual(temp[i].name, D_melodic_minor[i]);
            }
        }
        [TestMethod]
        public void A_pentatonic_melodic()
        {
            Pentatonic penta = new Pentatonic();
            List<Note> temp = new List<Note>();
            temp = penta.Melodic("A");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(temp[i].name, A_Pentatonic_melodic[i]);
            }
        }
        /// <summary>
        /// string[] C_bobop_mixolydian = {"C","D","E","F","G","A","Bb","B"}
        /// </summary>
        [TestMethod]
        public void C_beBob_mixolydian()
        {
            Bebop bebop = new Bebop();
            List<Note> temp = bebop.Mixolydian("C");
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(temp[i].name, C_bobop_mixolydian[i]);
            }
        }
        [TestMethod]
        public void D_beBop_Dorian()
        {
            Bebop bebop = new Bebop();
            List<Note> temp = bebop.Dorian("D");
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(temp[i].name, D_bebop_dorian[i]);
            }
        }
        [TestMethod]
        public void GChord_Major()
        {
            Chord chord = new Chord();
            List < Note >test = chord.Major("G");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(test[i].name, G_chord_major[i]);
            }

        }
        [TestMethod]
        public void AChord_Minor()
        {
            Chord chord = new Chord();
            List<Note> test = chord.Minor("A");
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(test[i].name, A_chord_minor[i]);
            }

        }
        [TestMethod]
        public void spanishScale()
        {
            Spanish scale = new Spanish();

            List<Note> test = scale.SpanishScale("C");
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i].name, C_Spanish_scale[i]);
            }

        }
    }
}
