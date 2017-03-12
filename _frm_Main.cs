using System;
using System.Windows.Forms;
using OpenCvSharp;

namespace WindowsFormsApplication1
{    
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void bStart_MouseClick(object sender, MouseEventArgs e)
        {

            //CvCapture camera = new CvCapture("C:\\rosbank\\facedetect\\test\\media\\test.avi");
            var capture = new VideoCapture("C:\\rosbank\\facedetect\\test\\media\\test.avi");
            //capture.Set(CaptureProperty.FrameWidth, 320);
            //capture.Set(CaptureProperty.FrameHeight, 240);
            
            int sleepTime = (int)Math.Round(1000 / capture.Fps);

            Mat image = new Mat();
            Rect[] faces = null;
            int i = 0;
            while (true)
            {
                i++;
                capture.Read(image); 
                if (image.Empty())
                    break;


                Mat small = new Mat();
                Cv2.Resize(image, small, new OpenCvSharp.Size(320, 240), 0, 0, InterpolationFlags.Lanczos4);                

                if (i % 5 == 0)
                {
                    var cascade = new CascadeClassifier(@"C:\opencv3\opencv\sources\data\haarcascades\haarcascade_frontalface_alt.xml");
                    faces = cascade.DetectMultiScale(small, 1.08, 2, HaarDetectionType.ScaleImage, new OpenCvSharp.Size(30, 30));
                    
                }
                if (faces != null && faces.Length > 0)
                {
                    foreach (Rect face in faces)
                    {
                        var center = new OpenCvSharp.Point
                        {
                            X = (int)(face.X + face.Width * 0.5),
                            Y = (int)(face.Y + face.Height * 0.5)
                        };
                        var axes = new OpenCvSharp.Size
                        {
                            Width = (int)(face.Width * 0.5),
                            Height = (int)(face.Height * 0.5)
                        };
                        
                        Mat f = new Mat(small, face);
                        pb1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(f);
                        pb1.Refresh();

                        Cv2.Ellipse(small, center, axes, 0, 0, 360, new Scalar(255, 0, 255), 2);
                    }
                }

                bpMain.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(small);
                bpMain.Refresh();
                Cv2.WaitKey(100);
            }    
        }
    }
}
