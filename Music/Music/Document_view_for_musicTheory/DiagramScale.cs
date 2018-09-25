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
    public partial class DiagramScale : Form
    {
        public DiagramScale(string key, string scale)
        {
            InitializeComponent();
            
            if(key == "A")
            {
                A(scale);
            }
            else if(key == "Ab"||key == "G#")
            {
                Ab(scale);
            }
            else if (key == "B" || key == "Cb")
            {
                B(scale);
            }
            else if (key == "Bb" || key == "A#")
            {
                Bb(scale);
            }
            else if(key == "C" || key == "B#")
            {
                C(scale);
            }
            else if (key == "D")
            {
                D(scale);
            }
            else if (key == "Db" || key == "C#")
            {
                Db(scale);
            }
            else if (key == "E" || key == "Fb")
            {
                E(scale);
            }
            else if (key == "Eb" || key == "D#")
            {
                Eb(scale);
            }
            else if (key == "F" || key == "E#")
            {
                F(scale);
            }
            
            else if (key == "G")
            {
                G(scale);
            }
            else if (key == "Gb" || key == "F#")
            {
                Gb(scale);
            }

        }
        private void A(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A Minor Natural Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Japenese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Japenese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Bebop Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\A\Scale\A (also G## or Bbb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Ab(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\G# or Ab Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\G# or Ab Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\G# or Ab Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\Ab or G# Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Ab\Scale\G# or Ab Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void B(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Hormonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Japanese(Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Japanese(Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Minor Bobop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also Cb or A##) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\B\Scale\B (also A## or Cb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Bb(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Bb\Scale\Bb or A# Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void C(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (B# or Dbb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (B# or Dbb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or D##) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or D##) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or D##) Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or D##) Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or Dbb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (B# or Dbb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or Dbb) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\C\Scale\C (also B# or Dbb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void D(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\D\Scale\D (also C## or Ebb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Db(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\Db Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\Db Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\Db or C# Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\Db or C# Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\Db or C# Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Db\Scale\C# or Db Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void E(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also Fb or D##) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E (also D## or Fb) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\E\Scale\E Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Eb(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\Eb or D# Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Eb\Scale\D# or Eb Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void F(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\F\Scale\F (also E# or Gbb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void G(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\G\Scale\G (also F## or Abb) Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Gb(string scale)
        {
            if (scale == "Major Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\Gb Major Scale.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Minor (Natural) Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Natural Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Harmonic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Harmonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Melodic Minor Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\Gb Melodic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Major")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\Gb or F# Pentatonic Major.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Pentatonic Minor")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Pentatonic Minor.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Blues")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Blues.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Sen)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Japanese (Sen).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Japanese (Hirajoshi)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Japanese (Hirajoshi).png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Mixolydian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Dominent Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Dorian)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Minor Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Bebop (Major)")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\Gb or F# Major Bebop.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (scale == "Spanish Scale")
            {
                pictureBox_scale.Image = new Bitmap(@"C:\Users\tom\Documents\Visual Studio 2017\Projects\Music\Document_view_for_musicTheory\Neck Diagram Pics\Gb\Scale\F# or Gb Spanish.png");
                pictureBox_scale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox_mode_Click(object sender, EventArgs e)
        {

        }
    }
}
