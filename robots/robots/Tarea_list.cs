using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace robots
{
    public class Tarea_list 
    {
        Queue miQ = new Queue();
        private static Tarea_list instancia = new Tarea_list();
    
        public Queue<Tarea> listaComandos = new Queue<Tarea>();


        public Tarea siguienteComando()
        {
            if (listaComandos.Count == 0)
            {
                return null;
            }
            Tarea t = listaComandos.t();
            t.state = estado_tarea.ocupado;
            listaComandos.Dequeue();
            return t;
        }

        public void agregarComando(Tarea comando)
        {
            listaComandos.Enqueue(comando);
        }

        public static Tarea_list cual()
        {
            return instancia;
        }

   
    }
}
