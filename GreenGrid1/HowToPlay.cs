using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Green_Grid //Defines the namespace Green_Grid to group related classes and avoid naming conflicts.
{
    public partial class HowToPlay : Form
    //Declares the HowToPlay class, which is a partial class
    //Inherits from Form, making it a Windows Forms class that represents a pop-up window (the "How to Play" screen).
    {
        Point ParentTopLeft; //Stores the top-left corner coordinates of the parent form.
        Size ParentSize; //Stores the dimensions of the parent form (width and height).

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //Imports the CreateRoundRectRgn function from the Windows GDI(Graphics Device Interface) library Gdi32.dll.
        //This function creates a region (used for clipping or hit-testing) with rounded corners.
        private static extern IntPtr CreateRoundRectRgn //is used to create a rounded rectangle region, which is essentially a shape with rounded corners.
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public HowToPlay(Point parentTopLeft, Size parentSize) //initializes the HowToPlay form and takes the parent form's top-left corner and size as arguments.
        {
            InitializeComponent(); //sets up the form's controls and properties.

            this.TopMost = true; //Ensures the HowToPlay form stays on top of all other windows when opened.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            //Sets the form's clipping region to a rounded rectangle using the CreateRoundRectRgn function.
            //Width and Height refer to the dimensions of the form, and 40, 40 specify the ellipse's width and height for rounded corners.
            ParentTopLeft = parentTopLeft; //Stores the parent form's top-left corner position for later use when positioning the HowToPlay form.
            ParentSize = parentSize; //Stores the parent form's size for the HowToPlay form
        }
        private void HowToPlay_Load(object sender, EventArgs e)
        {
            int tempY = (ParentSize.Height - this.Height) / 2; //Horizontal offset needed to center the form
            int tempX = (ParentSize.Width - this.Width) / 2; //Vertical offset needed to center the form
            int newX = ParentTopLeft.X + tempX; //Horizontal position relative to the parent's left edge
            int newY = ParentTopLeft.Y + tempY; //Vertical position relative to the parent's top edge
            if (newX < 0)
            {
                newX = 0;
            }
            if (newY < 0)
            {
                newY = 0;
            }
            this.Location = new Point(newX, newY); //is updated with the calculated position (newX, newY).
        }
        private void btnExit_Click(object sender, EventArgs e) //Handles the event triggered when the "Exit" button is clicked.
        {
            this.Hide(); //Hides the HowToPlay form but keeps it in memory.
            //The form can be shown again later without being re-created.
        }
        private void lblInstructions_Click(object sender, EventArgs e) //Placeholder event handler for when the user clicks on the label lblInstructions.
        {

        }

        private void lblHow_Click(object sender, EventArgs e)
        {

        }
    }
}


