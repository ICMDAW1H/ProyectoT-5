﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace practicagit
{
    public partial class ClasesAlumnosyAlumno : Form
    {
        public ClasesAlumnosyAlumno()
        {
            InitializeComponent();
        }


        Alumnos misAlumnos = new Alumnos();

        private void BGuardar_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            String miAlumnoStr;

            miAlumno.Nombre = aluNombre.Text;
            miAlumno.Nota = Convert.ToInt32(tnota.Text);
            miAlumnoStr = aluNombre.Text + " " + tnota.Text + (miAlumno.Aprobado ? " Aprobado" : " Suspenso") + "\n";
            listaAlumnos.AppendText(miAlumnoStr);
            misAlumnos.Agregar(miAlumno);
        }
        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        class Alumno
        {
            private string nombre;
            private int nota;
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Nota
            {
                get { return nota; }
                set
                {
                    if (value >= 0 && value <= 10)
                        nota = value;
                }
            }
            public Boolean Aprobado
            {
                get
                {
                    if (nota >= 5)
                        return true;
                    else
                        return false;
                }
            }
        }
        class Alumnos
        {
            private ArrayList listaAlumnos = new ArrayList();

            // Agrega un nuevo alumno a la lista
            //        
            public void Agregar(Alumno alu)
            {
                listaAlumnos.Add(alu);
            }

            // Devuelve el alumno que está en la posición num
            //
            public Alumno Obtener(int num)
            {
                if (num >= 0 && num <= listaAlumnos.Count)
                {
                    return ((Alumno)listaAlumnos[num]);
                }
                return null;
            }

            // Devuelve la nota media de los alumnos
            //
            public float Media
            {
                get
                {
                    if (listaAlumnos.Count == 0)
                        return 0;
                    else
                    {
                        float media = 0;
                        for (int i = 0; i < listaAlumnos.Count; i++)
                        {
                            media += ((Alumno)listaAlumnos[i]).Nota;
                        }
                        return (media / listaAlumnos.Count);
                    }
                }
            }
        }
    }
}
