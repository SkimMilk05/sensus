﻿// Copyright 2014 The Rector & Visitors of the University of Virginia
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Syncfusion.SfChart.XForms;

namespace Sensus.Probes.Apps
{
	/// <summary>
	/// Collects application usage stats as <see cref="ApplicationUsageStatsDatum"/>
	/// </summary>
	public abstract class ApplicationUsageStatsProbe : PollingProbe
	{
		public override int DefaultPollingSleepDurationMS
		{
			get
			{
				return (int)TimeSpan.FromHours(1).TotalMilliseconds;
			}
		}

		public override string DisplayName
		{
			get
			{
				return "Application Stats";
			}
		}

		public override Type DatumType
		{
			get
			{
				return typeof(ApplicationUsageEventDatum);
			}
		}

		protected override ChartDataPoint GetChartDataPointFromDatum(Datum datum)
		{
			throw new NotImplementedException();
		}

		protected override ChartAxis GetChartPrimaryAxis()
		{
			throw new NotImplementedException();
		}

		protected override RangeAxisBase GetChartSecondaryAxis()
		{
			throw new NotImplementedException();
		}

		protected override ChartSeries GetChartSeries()
		{
			throw new NotImplementedException();
		}
	}
}
