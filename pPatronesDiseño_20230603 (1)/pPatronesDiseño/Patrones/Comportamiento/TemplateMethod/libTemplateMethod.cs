using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.TemplateMethod
{
    public abstract class TeaTemplate
    {
        public void TeaTemplateMethod()
        {
            WaterAddition();
            MilkAddition();
            AddingTeaLeaves();
            SugarAddition();
            MessageBox.Show(this.GetType().Name +
                " is Ready to Be Served");
        }
        protected abstract void WaterAddition();
        protected abstract void MilkAddition();
        protected abstract void AddingTeaLeaves();
        protected virtual void SugarAddition()
        {
            MessageBox.Show("Sugar Added to Taste");
        }
    }


    public class LiptonTea : TeaTemplate
    {
        protected override void WaterAddition()
        {
            MessageBox.Show("Tea Started");
        }
        protected override void MilkAddition()
        {
            MessageBox.Show("Adding Milk in Boiled Water");
        }
        protected override void AddingTeaLeaves()
        {
            MessageBox.Show("Lipton Tea Added for " +
                "the Color and Flavor");
        }
        protected override void SugarAddition()
        {
            MessageBox.Show("Sugar Not Used");
        }

    }

    public class TetleyTea : TeaTemplate
    {
        protected override void WaterAddition()
        {
            MessageBox.Show("Tea Started");
        }
        protected override void MilkAddition()
        {
            MessageBox.Show("Adding Milk in Boiled Water");
        }
        protected override void AddingTeaLeaves()
        {
            MessageBox.Show("Tetley Tea Added for " +
                "the Color and Flavor");
        }
    }

}
