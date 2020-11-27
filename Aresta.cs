﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Aresta
    { 

    private int peso;
    private Vertice vert1;
    private Vertice vert2;
    private int direcao;

    public Aresta(Vertice vert1, Vertice vert2, int peso)
    {
        this.vert1 = vert1;
        this.vert2 = vert2;
        this.peso = peso;
    }

    public Aresta(Vertice vert1, Vertice vert2, int peso, int direcao)
    {
        this.vert1 = vert1;
        this.vert2 = vert2;
        this.peso = peso;
        this.direcao = direcao;
    }

    public Vertice Vert1 { get { return vert1; } }

    public Vertice Vert2 { get { return vert2; } }

    public int Peso { get { return peso; } }

    public int Direcao { get { return direcao; } }
}
}
