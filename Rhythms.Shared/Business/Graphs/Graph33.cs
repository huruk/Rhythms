﻿#if XAMARIN_ANDROID
using Android.Graphics;
#endif
using Rhythms.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Rhythms.Shared.Business.Graphs
{
	public class Graph33 : GraphBase
	{
#if XAMARIN_ANDROID
		protected override Color Color => Color.Rgb(0, 128, 0);
#endif

		protected override string Name => Period.ToString();

		protected override int Period => 33;
	}
}
