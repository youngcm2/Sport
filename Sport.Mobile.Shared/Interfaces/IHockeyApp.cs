using System;
using System.Collections.Generic;

namespace Sport.Mobile.Shared
{
	public interface IHockeyApp
	{
		void ShowFeedback();
		void TrackEvent(string eventName, IDictionary<string, string> properties, IDictionary<string, double> measurements);
		void TrackEvent(string eventName);
	}
}
