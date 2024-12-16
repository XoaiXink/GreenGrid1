using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Green_Grid //Groups related classes and code together for the Green_Grid application.
{
    public partial class Info : Form
    //Declares the Info class as part of the form(UI) system.
    // indicates that other parts of this class might be defined elsewhere
    {
        Point ParentTopLeft; //Stores the top-left corner coordinates of the parent form.
        Size ParentSize; //Stores the size (width and height) of the parent form.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //Imports the CreateRoundRectRgn function from the Windows GDI (Graphics Device Interface) library Gdi32.dll.
        //This function creates a region (used for clipping or hit-testing) with rounded corners.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Info(Point parentTopLeft, Size parentSize)
        //initializes the Info form.
        //Takes the parent form’s location (parentTopLeft) and size (parentSize) as arguments.
        {
            InitializeComponent();
            //Initializes UI components(defined in the form designer).
            this.TopMost = true; //Ensures the Info form stays on top of all other windows.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40)); //Sets the form’s display region to the rounded rectangle created by CreateRoundRectRgn.
            ParentTopLeft = parentTopLeft; //Store the parent form’s location for centering the Info form.
            ParentSize = parentSize; //Store the parent form’s size for centering the Info form.
        }
        private void Info_Load(object sender, EventArgs e)
        {
            int tempY = (ParentSize.Height - this.Height) / 2;
            int tempX = (ParentSize.Width - this.Width) / 2;
            int newX = ParentTopLeft.X + tempX;
            int newY = ParentTopLeft.Y + tempY;
            if (newX < 0)
            {
                newX = 0;
            }
            if (newY < 0)
            {
                newY = 0;
            }
            this.Location = new Point(newX, newY);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides the Info form without closing it.

        }

        private void lblTitle_Click(object sender, EventArgs e) //Triggered when the user clicks on the lblTitle label.
        {

        }

        private void label2_Click(object sender, EventArgs e) //Triggered when the user clicks on the label2 control.
        {

        }

        private void pnlLink_Paint(object sender, PaintEventArgs e) //Triggered when the pnlLink panel is repainted (e.g., resized or refreshed).
        {

        }
    }
}


