﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// O365O365 connector card multiple choice input item.
    /// </summary>
    public class O365ConnectorCardMultichoiceInputChoice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365ConnectorCardMultichoiceInputChoice"/> class.
        /// </summary>
        public O365ConnectorCardMultichoiceInputChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="O365ConnectorCardMultichoiceInputChoice"/> class.
        /// </summary>
        /// <param name="display">The text rendered on ActionCard.</param>
        /// <param name="value">The value received as results.</param>
        public O365ConnectorCardMultichoiceInputChoice(string display = default, string value = default)
        {
            Display = display;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets the text rendered on ActionCard.
        /// </summary>
        /// <value>The text rednered on ActionCard.</value>
        [JsonPropertyName("display")]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value received as results.
        /// </summary>
        /// <value>The value received as results.</value>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}
