using System;
namespace robots
{
    public class estado_tarea
    {
        public estado_tarea(){ }
        public static estado_tarea ocupado = new estado_tarea();
        public static estado_tarea libre = new estado_tarea();
        public static estado_tarea esperando = new estado_tarea();
    }
}
