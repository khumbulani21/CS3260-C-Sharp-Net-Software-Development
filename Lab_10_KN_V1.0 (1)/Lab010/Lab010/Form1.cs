using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab010
{
    public partial class FrmLab10 : Form
    {
        NList list = new NList();
        public FrmLab10()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //check if CNode radio button is checked
            if(RBtnCNode.Checked)
            {

                string temp = TxtCost.Text.Trim();
                decimal myCost = 0;
                string yearString = TxtYear.Text.Trim();
                uint yearX = 0;
                //check if input is valid and create a node
                if (Decimal.TryParse(temp, out myCost) == true && uint.TryParse(yearString, out yearX) == true )
                {
                    CNode nodeA = new CNode();
                    nodeA.CDate = DTime.Value;
                    nodeA.Cost = myCost;
                    nodeA.Description = TxtDescription.Text.Trim();
                    nodeA.MakeModel = TxtModel.Text.Trim();
                    nodeA.Year = yearX;
                    list.Push_Front(nodeA);
                    RTBoxInfo.AppendText("New node created: "+nodeA.ToString() +" \n");

                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }
             
                //RTBoxInfo.AppendText(nodeA.CDate.ToString());

            }
            else if(RBtnSNode.Checked)
            {

                string stringQuantity = TxtQuantity.Text.Trim();
               
                string yearString = TxtYear.Text.Trim();
                uint quantityX = 0;
                if ( uint.TryParse(stringQuantity, out quantityX) == true)
                {
                    SNode nodeB = new SNode();
                    nodeB.Descrption = TxtDescription.Text.Trim();
                    nodeB.SupplyName = TxtSName.Text.Trim();
                    nodeB.Quantity = quantityX;

                    list.Push_Front(nodeB);
                    RTBoxInfo.AppendText(nodeB.ToString()+" \n");

                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }
            }

           
        }

        /// <summary>
        /// Event handler to make components visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnCNode_CheckedChanged(object sender, EventArgs e)
        {

            LblQuantity.Visible = false;
            LblSName.Visible = false;
            TxtSName.Visible = false;
            TxtQuantity.Visible = false;
            //make components visible
            LblDate.Visible = true;
            LblCost.Visible = true;
            LblYear.Visible = true;
            LblModel.Visible = true;
            TxtCost.Visible = true;
            TxtModel.Visible = true;
            TxtYear.Visible = true;
            DTime.Visible = true;
        }
        /// <summary>
        /// Make components for SNode visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnSNode_CheckedChanged(object sender, EventArgs e)
        {

            LblDate.Visible = false;
            LblCost.Visible = false;
            LblYear.Visible = false;
            LblModel.Visible = false;
            TxtCost.Visible = false;
            TxtModel.Visible = false;
            TxtYear.Visible = false;
            DTime.Visible = false;

            LblQuantity.Visible = true;
            LblSName.Visible = true;
            TxtSName.Visible = true;
            TxtQuantity.Visible = true;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            RTBoxList.Clear();
            RTBoxList.AppendText(list.DisplayList());

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RTBoxInfo.Clear();
            RTBoxList.Clear();
            list.ClearList();
           
        }

        private void BtnPLast_Click(object sender, EventArgs e)
        {
            //check if CNode radio button is checked
            if (RBtnCNode.Checked)
            {

                string temp = TxtCost.Text.Trim();
                decimal myCost = 0;
                string yearString = TxtYear.Text.Trim();
                uint yearX = 0;
                //check if input is valid and create a node
                if (Decimal.TryParse(temp, out myCost) == true && uint.TryParse(yearString, out yearX) == true)
                {
                    CNode nodeA = new CNode();
                    nodeA.CDate = DTime.Value;
                    nodeA.Cost = myCost;
                    nodeA.Description = TxtDescription.Text.Trim();
                    nodeA.MakeModel = TxtModel.Text.Trim();
                    nodeA.Year = yearX;
                    list.Push_Rear(nodeA);
                    RTBoxInfo.AppendText("New node created: " + nodeA.ToString() + " \n");

                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }

                //RTBoxInfo.AppendText(nodeA.CDate.ToString());

            }
            else if (RBtnSNode.Checked)
            {

                string stringQuantity = TxtQuantity.Text.Trim();

                string yearString = TxtYear.Text.Trim();
                uint quantityX = 0;
                if (uint.TryParse(stringQuantity, out quantityX) == true)
                {
                    SNode nodeB = new SNode();
                    nodeB.Descrption = TxtDescription.Text.Trim();
                    nodeB.SupplyName = TxtSName.Text.Trim();
                    nodeB.Quantity = quantityX;

                    list.Push_Rear(nodeB);
                    RTBoxInfo.AppendText(nodeB.ToString() + " \n");

                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }
            }

        }
        /// <summary>
        /// event handler that removes a node from the rear of the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPopLast_Click(object sender, EventArgs e)
        {
            list.Pop_Rear();
           
        }
        /// <summary>
        /// event handler that removes a node from the rear of the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPopFirst_Click(object sender, EventArgs e)
        {
            list.Pop_Front();
        }
    }
}
