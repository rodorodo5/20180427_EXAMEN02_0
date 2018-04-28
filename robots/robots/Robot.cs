using System;
using System.Collections.Generic;
using System.Linq;

namespace robots
{
    public class Robot 
    {
        List<Tarea> listaComandos = new List<Tarea>();
        string RobotName;
        int complejidad;

        public Robot(String RobotName, int complejidad)
        {
            this.RobotName = RobotName;
            this.complejidad = complejidad;
            //asignarCommand();
        }

        public void trabajar()
        {
            Console.WriteLine("Robot: " + RobotName + " Comenzara a trabajar");
            while (listaComandos != null && listaComandos.Count() > 0)
            {
                for (int i = 0; i < listaComandos.Count; i++)
                {
                    listaComandos.ElementAt(i); //ejecutar
                    listaComandos.RemoveAt(i);
                }
                agregarCommand();
            }
        }

        private void agregarCommand()
        {
            for (int i = listaComandos.Count; i < complejidad; i++)
            {
                Tarea siguienteComando = Tarea_list.cual().siguienteComando();
                if (siguienteComando == null)
                    break;
                listaComandos.Add(siguienteComando);
                Console.WriteLine(RobotName + " Nuevo comando: " );
            }
        }

       

    }
}
