namespace DemoMVVMAprendices.Model
{
    using DemoMVVMAprendices.ViewModel;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Aprendiz: Notificable
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string programa;
        private double ficha;
        private double promedio;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (apellido == value)
                {
                    return;
                }
                apellido = value;
                OnPropertyChanged();
            }
        }
        public string Programa
        {
            get { return programa; }
            set
            {
                if (programa == value)
                {
                    return;
                }
                programa = value;
                OnPropertyChanged();
            }
        }
        public double Ficha
        {
            get { return ficha; }
            set
            {
                if (ficha == value)
                {
                    return;
                }
                ficha = value;
                OnPropertyChanged();
            }
        }
        public double Promedio
        {
            get { return promedio; }
            set
            {
                if (promedio == value)
                {
                    return;
                }
                promedio = value;
                OnPropertyChanged();
            }
        }

        #endregion

    }
}
