using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class Desk : Form
    {
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }


        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public Desk()
        {
            InitializeComponent();
        }

        private void Desk_Load(object sender, EventArgs e)
        {

        }
    }
}
