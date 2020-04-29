﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ExposureNotifications
{
	public static partial class ExposureNotification
	{
		static Task PlatformStart(IExposureNotificationHandler handler)
			=> throw new PlatformNotSupportedException();

		static Task PlatformStop()
			=> throw new PlatformNotSupportedException();

		static Task<bool> PlatformIsEnabled()
			=> throw new PlatformNotSupportedException();

		// Gets the contact info of anyone the user had contact with who was diagnosed
		static Task<IEnumerable<ContactInfo>> PlatformGetContacts()
			=> throw new PlatformNotSupportedException();

		// Call this when the user has confirmed diagnosis
		static Task PlatformSubmitPositiveDiagnosis()
			=> throw new PlatformNotSupportedException();

		// Tells the local API when new diagnosis keys have been obtained from the server
		static Task PlatformProcessDiagnosisKeys(IEnumerable<TemporaryExposureKey> diagnosisKeys)
			=> throw new PlatformNotSupportedException();
	}
}
