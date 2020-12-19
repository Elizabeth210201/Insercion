using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insercion2._0
{
  public partial class Form1 : Form
  {
    Random aleatorio;
    int[] arreglo;
    public Form1()
    {
      InitializeComponent();
      aleatorio = new Random();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DateTime a = DateTime.Now;
      a = DateTime.Now;
      DateTime b= DateTime.Now;
      b = DateTime.Now;
      int[] vector = new int[4];
      
      vector= new int [int.Parse(Pos1.Text)];
      //vector[0] = int.Parse(Pos1.Text);
      //vector[1] = int.Parse(Pos2.Text);
      //vector[2] = int.Parse(Pos3.Text);
      for (int i = 0; i < vector.Length; i++)
      {
        vector[i] = aleatorio.Next(0, 100);
        arreglo = vector;
      }
      Ordenamiento(vector);
      listBox1.Text = "Vector Ordenado" + Environment.NewLine;
      for (int i = 0; i < arreglo.Length; i++)
      {
        listBox1.Items.Add(arreglo[i]);
      }
      TimeSpan c = b - a;
      label6.Text = c.Milliseconds + "" + "Milisegundos";
      label7.Text = c.Seconds + "" + "Segundos";
      Pos1.Clear();
      Pos1.Focus();
      
      //foreach (int elementos in vector)
      //{
      //  textBox5.Text += elementos + Environment.NewLine;
      
      //  DateTime b = DateTime.Now;
       
      //  b = DateTime.Now;
      //  TimeSpan c = b - a;
       
      
        
      //  label6.Text = c.Milliseconds + " " + "Milisegundos";
      //  label7.Text = c.Seconds + " " + "Segundos";
        
      // // break;
      //}
    }
    void Ordenamiento(int []vector)
    {
      int posicion = 0; // la posicion del numero a analizar en el vector
      int aux = 0; // aqui guardamos el valor si se necesita mover
      int tamaño = vector.Length;
      for (int i = 1; i < tamaño; i++)
      {
        posicion = 0;
        for (int j = i; j > 0; j--)
        {
          if (vector [i+posicion]<vector[j-1])//empezamos a modificar las posiciones del vector
          {
            aux = vector[i + posicion]; //guardamos el valor que vamos a desplazar
            vector[i + posicion] = vector[j - 1];
            vector[j - 1] = aux; //desplazamos y cambiamos posicion 
            posicion--;// Cambiamos nuestra posicion a revisar
          
          }
          else { break; }
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }
  }
}
