using System;

namespace SwipeableViewCell
{
	public static class FloatExtensions
	{
		/// <summary>
		/// Returns the -1.0F * this float
		/// </summary>
		public static nfloat Neg(this nfloat f)
		{
			return -1.0F * f;
		}
	}
}
