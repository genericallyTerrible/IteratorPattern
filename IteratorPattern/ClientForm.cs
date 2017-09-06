using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class ClientForm : Form
    {
        ConcreteTree<int> tree;

        public ClientForm()
        {
            InitializeComponent();
        }

        // Numeric values only
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textboxSender = (TextBox)sender;
            int cursorPosition = textboxSender.SelectionStart;

            // This line removes the non-matching characters, but also causes
            // the InputTextBox_TextChanged event to be fired again.
            // This results in the cursor not being correctly placed.
            // Not sure yet how to fix it.
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void CreateTreeButton_Click(object sender, EventArgs e)
        {
            tree = new ConcreteTree<int>();

            int count = (int)InputTreeUpDown.Value;

            // Super inefficient, but it's just a demo.
            for (int i = 1; i <= count; i++)
            {
                tree.Push(i);
            }
        }

        private void InorderTraverseButton_Click(object sender, EventArgs e)
        {
            if (IsValidTree())
            {
                InorderListBox.Items.Clear();

                InorderIterator<int> inorder = tree.CreateInorderIterator();

                InorderListBox.Items.Add(inorder.First());

                while (!inorder.IsDone())
                {
                    InorderListBox.Items.Add(inorder.Next());
                }
            }
        }

        private void PreorderTraverseButton_Click(object sender, EventArgs e)
        {
            if (IsValidTree())
            {
                PreorderListBox.Items.Clear();

                PreorderIterator<int> preorder = tree.CreatePreorderIterator();

                PreorderListBox.Items.Add(preorder.First());

                while (!preorder.IsDone())
                {
                    PreorderListBox.Items.Add(preorder.Next());
                }
            }
        }

        private void PostorderTraversalButton_Click(object sender, EventArgs e)
        {
            if (IsValidTree())
            {
                PostorderListBox.Items.Clear();

                PostorderIterator<int> postorder = tree.CreatePostorderIterator();

                PostorderListBox.Items.Add(postorder.First());

                while (!postorder.IsDone())
                {
                    PostorderListBox.Items.Add(postorder.Next());
                }
            }
        }

        private bool IsValidTree()
        {
            return tree != null && tree.Nodes.Count > 0;
        }
    }
}
