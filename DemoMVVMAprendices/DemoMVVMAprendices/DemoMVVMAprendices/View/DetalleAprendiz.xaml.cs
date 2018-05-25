using DemoMVVMAprendices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMVVMAprendices.View
{
	public partial class DetalleAprendiz : ContentPage
	{
		public DetalleAprendiz (Aprendiz aprendizSeleccionado)
		{
            InitializeComponent();
            this.BindingContext = aprendizSeleccionado;
		}
	}
}