using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnimauxMenuContextuel
{
    public partial class AnimauxMenuContextuelForm : Form
    {
        public AnimauxMenuContextuelForm()
        {
            InitializeComponent();
        }
        private void AnimauxMenuContextuelForm_Load(object sender, EventArgs e)
        {
            animauxListBox.Text = "baleine";
        }

        private void animauxContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // Supprimer + Item Selectionne

            if (animauxListBox.SelectedIndex != -1)
            {
                animauxContextMenuStrip.Items[0].Text = "Supprimer : " + animauxListBox.SelectedItem.ToString();
                animauxContextMenuStrip.Enabled = true;
            }
            else
            {
                animauxContextMenuStrip.Items[0].Text = "Aucun animal de sélectionné.";
                animauxContextMenuStrip.Enabled = false;
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int positionInt = animauxListBox.SelectedIndex;
            animauxListBox.Items.RemoveAt(positionInt);

            // Verification
            if (animauxListBox.Items.Count >= 1)
            {
                if (positionInt >= animauxListBox.Items.Count)
                    positionInt--;

                animauxListBox.SelectedIndex = positionInt;
            }
        }

        private void retrouverButton_Click(object sender, EventArgs e)
        {
            if (nomAnimalTextBox.Text.Length != 0)
            {
                int position = IndiceListe(animauxListBox, nomAnimalTextBox.Text);

                if (position != -1)
                    animauxListBox.SelectedIndex = position;
                else
                    MessageBox.Show("Un animal est obligatoire");
            }
        }

        private void InsererButton_Click(object sender, EventArgs e)
        {
            if (nomAnimalTextBox.Text.Length != 0)
            {
                int position = IndiceListe(animauxListBox, nomAnimalTextBox.Text);

                if (position != -1)
                {
                    MessageBox.Show("L'animal existe deja dans la liste");
                    animauxListBox.SelectedIndex = position;
                }
                else
                {
                    int itemSelectionne = animauxListBox.SelectedIndex;

                    if (itemSelectionne == -1)
                        itemSelectionne = 0;

                    animauxListBox.Items.Insert(itemSelectionne, nomAnimalTextBox.Text);
                    animauxListBox.SelectedIndex = itemSelectionne;
                }
            }
            else
                MessageBox.Show("Un animal est obligatoire afin de pouvoir l'ajouter a la liste");

            nomAnimalTextBox.Focus();
        }

        private int IndiceListe(ListBox liste, string item)
        {
            int positionRetrouvee = -1;

            if (liste != null && item != null && item != string.Empty && liste.Items.Count > 0)
            {
                int positionCourante = 0;

                do
                {
                    if (string.Compare(liste.Items[positionCourante].ToString(), item, true) == 0)
                        positionRetrouvee = positionCourante;

                    positionCourante++;

                }
                while (positionRetrouvee == -1 && positionCourante < liste.Items.Count);
            }
            return positionRetrouvee;
        }
    }
}
