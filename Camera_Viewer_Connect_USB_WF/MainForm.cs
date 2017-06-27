using System;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using System.Drawing;
using ZXing;

namespace Camera_Viewer_Connect_USB_WF
{
    public partial class MainForm : Form
    {
        private FrameCapture _capture;

        private WebCamera _webCamera;

        private MediaConnector _connector;

        private DrawingImageProvider _liveProvider;

        private VideoResizer _resizeHandler;
        
        public MainForm()
        {
            InitializeComponent();
            _liveProvider = new DrawingImageProvider();
            _resizeHandler = new VideoResizer();

            _capture = new FrameCapture();
            _connector = new MediaConnector();
        }

        private void connectBt_Click(object sender, EventArgs e)
        {
            try
            {
                disconnectBt.Enabled = true;

                _webCamera = new WebCamera();

                _connector.Connect(_webCamera, _liveProvider);

                _connector.Connect(_webCamera, _capture);

                _connector.Connect(_webCamera.VideoChannel, _resizeHandler);

                _resizeHandler.SetResolution(600, 800);

                liveViewer.SetImageProvider(_liveProvider);
                liveViewer.Start();

                

                _webCamera.Start();

                start();

                connectBt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disconnectBt_Click(object sender, EventArgs e)
        {
            try
            {

                stop();

                _capture.Stop();
                _webCamera.Stop();

                _connector.Disconnect(_webCamera, _liveProvider);

                _connector.Disconnect(_webCamera, _capture);

                liveViewer.Stop();

                _capture.Dispose();


                connectBt.Enabled = true;
                disconnectBt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void start()
        {
            try
            {
                _capture.SetInterval(new TimeSpan(0, 0, 0, 0, 500));
                _capture.Start();
                _capture.OnFrameCaptured += _capture_OnFrameCaptured;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void _capture_OnFrameCaptured(object sender, Snapshot e)
        {
            var image = e.ToImage();

            try
            {
                BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryHarder = true };
                reader.Options.TryHarder = true;
                Result result = reader.Decode(new Bitmap(image));
                if (result.Text.Contains("[{"))
                {
                    txtDecodedData.Text = result.Text;
                    stop();
                    disconnectBt_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                txtDecodedData.Text += "Error: " + (ex.Message) + " \r\n\r\n";
            }
        }

        private void stop()
        {
            _capture.Stop();
            _capture.OnFrameCaptured -= _capture_OnFrameCaptured;
        }
    }
}