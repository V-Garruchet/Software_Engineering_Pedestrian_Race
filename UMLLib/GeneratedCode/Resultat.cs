﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Resultat
{
	public virtual int Id
	{
		get;
		set;
	}

	public virtual Participant Participant
	{
		get;
		set;
	}

	public virtual int Classement
	{
		get;
		set;
	}

	public virtual DateTime Temps
	{
		get;
		set;
	}

	public Resultat(int id, Participant participant, int classement, DateTime temps)
	{
	}

}

