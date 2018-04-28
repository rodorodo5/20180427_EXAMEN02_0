using System;
namespace robots
{
    public class Tarea : Interface_command
    {
        public int RobotID;
        public int complejidad;
        public bool Trabajando;
        public estado_tarea state = estado_tarea.esperando;

        public Tarea(int complejidad, int RobotID)
        {
            this.complejidad = complejidad;
            this.RobotID = RobotID;
        }

        public void ejecutar()
        {
            
        }

        public void cancelar()
        {
            
        }
    }
}
