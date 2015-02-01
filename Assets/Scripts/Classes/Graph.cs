using System;
using UnityEngine;
public class Graph
{
	Line demand;
	public Graph (Line demand)
	{
		this.demand = demand;
	}
}
public class Line
{
	public Vector2 f;
	public Vector2 s;
	public Line(Vector2 f, Vector2 s)
	{
		this.f = f;
		this.s = s;
	}
}