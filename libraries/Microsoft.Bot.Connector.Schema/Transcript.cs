﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema
{
    /// <summary>
    /// Transcript.
    /// </summary>
    public class Transcript
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript"/> class.
        /// </summary>
        public Transcript()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript"/> class.
        /// </summary>
        /// <param name="activities">A collection of Activities that conforms
        /// to the Transcript schema.</param>
        public Transcript(IList<Activity> activities = default)
        {
            Activities = activities;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets a collection of Activities that conforms to the
        /// Transcript schema.
        /// </summary>
        /// <value>A collection of activities that conforms to the Transcript schema.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("activities")]
        public IList<Activity> Activities { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}
