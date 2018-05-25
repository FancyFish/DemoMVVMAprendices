namespace DemoMVVMAprendices.Model.Services
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    public class CaracterizacionAprendices
    {
        public static Data CargarAprendices()
        {
            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data carAprendices = new Data();
            string[] nombres = { "Andres", "Monica", "Viviana", "Rocio", "Camilo", "Rodrigo", "Paola", "Carlos" };
            string[] apellidos = { "Acevedo", "Amaya", "Monroy", "Acosta" };
            string[] programas = { "ADSI", "Móviles", "Multimedia", "Diseño", "Programación" };
            Random rnm = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();
            
            for (int i = 0; i < 20; i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rnm.Next(0, 7)];
                aprendiz.Apellido = $"{apellidos[rnm.Next(0, 3)]} {apellidos[rnm.Next(0, 3)]}";
                double ficha = rnm.Next(536897, 900000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rnm.Next(0, 4)];
                aprendiz.Promedio = rnm.Next(100, 1000);
                aprendices.Add(aprendiz);
            }
            carAprendices.Aprendices = aprendices;
            return carAprendices;
        }
    }
}
