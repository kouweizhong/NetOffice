﻿using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834593.aspx </remarks>
	[SupportByVersionAttribute("Word", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlChartElementPosition
	{
		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>-4105</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlChartElementPositionAutomatic = -4105,

		 /// <summary>
		 /// SupportByVersion Word 14, 15, 16
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("Word", 14,15,16)]
		 xlChartElementPositionCustom = -4114
	}
}