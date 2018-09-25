using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_view_for_musicTheory
{
    public partial class DiagramMode : Form
    {
        public DiagramMode(string key, string mode)
        {
            InitializeComponent();
            if (key == "A")
            {
                A(mode);
            }
            else if (key == "Ab" || key == "G#")
            {
                Ab(mode);
            }
            else if (key == "B" || key == "Cb")
            {
                B(mode);
            }
            else if (key == "Bb" || key == "A#")
            {
                Bb(mode);
            }
            else if (key == "C" || key == "B#")
            {
                C(mode);
            }
            else if (key == "D")
            {
                D(mode);
            }
            else if (key == "Db" || key == "C#")
            {
                Db(mode);
            }
            else if (key == "E" || key == "Fb")
            {
                E(mode);
            }
            else if (key == "Eb" || key == "D#")
            {
                Eb(mode);
            }
            else if (key == "F" || key == "E#")
            {
                F(mode);
            }

            else if (key == "G")
            {
                G(mode);
            }
            else if (key == "Gb" || key == "F#")
            {
                Gb(mode);
            }

        }
        private void A (string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A (also G## or Bbb) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A (also G## or Bbb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A (also G## or Bbb) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A (also G## or Bbb) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A Aeolian .png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Mode\A (also G## or Bbb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Ab(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\Ab Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\Ab or G# Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\G# or Ab Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\Ab or G# Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\Ab or G# Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\G# or Ab Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Mode\G# or Ab Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void B(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B (also A## or Cb) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B (also A## or Cb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B (also A## or Cb) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B (also A## or Cb) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B (also A## or Cb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Mode\B Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Bb(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb or A# Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb or A# Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb or A# Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb or A# Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Bb\Mode\Bb or A# Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Mode\Bb or A# Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void C (string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C Iolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (also B# or Dbb) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (also B# or Dbb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (also B# or Dbb) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (also B# or Dbb) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (B# or Dbb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Mode\C (also B# or Dbb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void D (string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D (also C## or Ebb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D (also C## or Ebb) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D (also C## or Ebb) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D (also C## or Ebb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Mode\D (also C## or Ebb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Db(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\Db Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\C# or Db Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\C# or Db Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\Db or C# Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\Db or C# Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\C# or Db Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Mode\C# or Db Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void E(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E (also Fb or D##) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E (also Fb or D##) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E (also Fb or D##) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E (also D## or Fb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Mode\E (also D## or Fb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Eb(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\Eb Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\Eb or D# Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\D# or Eb Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\Eb or D# Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\Eb or D# Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\Eb or D# Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Mode\D# or Eb Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void F(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F Iolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F (also E# or Gbb) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F (also E# or Gbb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F (also E# or Gbb) Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F (also E# or Gbb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Mode\F (also E# or Gbb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void G(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G (also F## or Abb) Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G (also F## or Abb) Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G (also Abb or F##) Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G (also F## or Abb) Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Mode\G (also F## or Abb) Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Gb(string mode)
        {
            if (mode == "Ionian (I)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\Gb Ionian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Dorian (II)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\F# or Gb Dorian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Phrygian (III)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\F# or Gb Phrygian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Lydian (IV)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\Gb or F# Lydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Mixolydian (V)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\F# or Gb Mixolydian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Aeolian (VI)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\F# or Gb Aeolian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (mode == "Locrian (VII)")
            {
                pictureBox_mode.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Mode\F# or Gb Locrian.png");
                pictureBox_mode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox_mode_Click(object sender, EventArgs e)
        {

        }
    }
}
