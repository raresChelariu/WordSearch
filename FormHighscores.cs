using System.Windows.Forms;

namespace WordSearch
{
    public partial class FormHighscores : Form
    {
        public FormHighscores()
        {
            InitializeComponent();
            if (Player.top10 == null)
                Player.LoadTop10FromHighscoreFile();

            if (Player.top10.Count == 0)
                MessageBox.Show("Niciun jucator nu a reusit sa castige pana acum!");

            foreach (Player p in Player.top10)
                listBoxHighscores.Items.Add(p.ToPrettyString());


        }
    }
}
