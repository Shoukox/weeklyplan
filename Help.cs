using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            HelpText.Text = "Кароч сверху кнопочки ты же не тупой да надеюсь сам поймешь что они значат. После нажатия кнопочек с днями недель под ними появится записка на этот день. Вы можете изменить эту записку, написав там свой текст и нажав на кнопку Edit Plan. Кнопка Restart рестартнет прогу";
        }

    }
}
