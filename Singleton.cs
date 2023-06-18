using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Singleton : MonoBehaviour
    {
        public static Singleton Instance;

        public int valor;
        public Singleton(int valor)
        {
            if (Instance == null)
                Instance = this;
            this.valor = valor;
        }
    }
}
