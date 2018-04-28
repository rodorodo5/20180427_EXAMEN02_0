using System;
namespace robots.Tareas
{
    public class HacerNuggets : Tarea
    {
        string queCocinar;

        public HacerNuggets(int complejidad, int RobotID , string que) : base(complejidad, RobotID)
        {
            queCocinar = que;
            this.descripcion = RobotID + ": Cocinar" + queCocinar;
        }

        public descrip
    }
}
