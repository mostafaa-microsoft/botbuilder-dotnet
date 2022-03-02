﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// Specifies if a notification is to be sent for the mentions.
    /// </summary>
    public class NotificationInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInfo"/> class.
        /// </summary>
        public NotificationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInfo"/> class.
        /// </summary>
        /// <param name="alert">true if notification is to be sent to the user,
        /// false otherwise.</param>
        public NotificationInfo(bool? alert = default)
        {
            Alert = alert;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets true if notification is to be sent to the user, false
        /// otherwise.
        /// </summary>
        /// <value>Boolean indicating if notification is sent to the user.</value>
        [JsonPropertyName("alert")]
        public bool? Alert { get; set; }

        /// <summary>
        /// Gets or sets the value indicating if a notification is to be shown to the user while in a meeting,
        /// false otherwise.
        /// </summary>
        /// <value>Boolean indicating if a notification is to be shown to the user while in a meeting.</value>
        [JsonPropertyName("alertInMeeting")]
        public bool? AlertInMeeting { get; set; }

        /// <summary>
        /// Gets or sets the value of the notification's external resource URL.
        /// </summary>
        /// <value>The value of the notification's external resource URL.</value>
        [JsonPropertyName("externalResourceUrl")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string ExternalResourceUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}
