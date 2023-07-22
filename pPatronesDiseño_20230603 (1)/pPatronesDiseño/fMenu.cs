using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnFactoryMethod_Click(object sender, EventArgs e)
        {
            Form1 fFactoryMethod = new Form1();
            fFactoryMethod.Show();
        }

        private void btnAbstractFactory_Click(object sender, EventArgs e)
        {
            fAbstractFactory fAbstractFactory = new fAbstractFactory();
            fAbstractFactory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBuilder builder = new fBuilder();
            builder.Show();
        }

        private void btnPrototipo_Click(object sender, EventArgs e)
        {
            fPrototype prototype = new fPrototype();
            prototype.Show();
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            fSingleton singleton= new fSingleton();
            singleton.Show();
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            fAdapter adapter = new fAdapter();
            adapter.Show();
        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            fBridge bridge = new fBridge();
            bridge.Show();
        }

        private void btnComposite_Click(object sender, EventArgs e)
        {
            fComposite composite = new fComposite();
            composite.Show();
        }

        private void btnDecorator_Click(object sender, EventArgs e)
        {
            fDecorator decorator = new fDecorator();
            decorator.Show();
        }

        private void btnFacade_Click(object sender, EventArgs e)
        {
            fFacade facade = new fFacade();
            facade.Show();
        }

        private void btnFlyWeight_Click(object sender, EventArgs e)
        {
            fFlyWeight flyWeight = new fFlyWeight();
            flyWeight.Show();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            fBaseDatos baseDatos = new fBaseDatos();
            baseDatos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fObserver observer = new fObserver();
            observer.Show();
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            fProxy fproxy = new fProxy();
            fproxy.Show();
        }

        private void btnChainResponsability_Click(object sender, EventArgs e)
        {
            fChainResponsability fChain = new fChainResponsability();
            fChain.Show();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            fCommand fcommand = new fCommand();
            fcommand.Show();
        }

        private void btnIterator_Click(object sender, EventArgs e)
        {
            fIterator fiterator = new fIterator();
            fiterator.Show();
        }

        private void btnMediator_Click(object sender, EventArgs e)
        {
            fMediator fmediator = new fMediator();
            fmediator.Show();
        }

        private void btnMemento_Click(object sender, EventArgs e)
        {
            fMemento fmemento = new fMemento();
            fmemento.Show();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            fState fstate = new fState();
            fstate.Show();
        }

        private void btnStrategy_Click(object sender, EventArgs e)
        {
            fStrategy fstrategy = new fStrategy();
            fstrategy.Show();
        }

        private void btnTemplateMethod_Click(object sender, EventArgs e)
        {
            fTemplateMethod fTemplate = new fTemplateMethod();
            fTemplate.Show();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            fVisitor fvisitor = new fVisitor();
            fvisitor.Show();
        }
    }
}
