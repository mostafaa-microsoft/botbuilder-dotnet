﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// Represents the entity that was mentioned in the message.
    /// </summary>
    public class MessageActionsPayloadMention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionsPayloadMention"/> class.
        /// </summary>
        public MessageActionsPayloadMention()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageActionsPayloadMention"/> class.
        /// </summary>
        /// <param name="id">The id of the mentioned entity.</param>
        /// <param name="mentionText">The plaintext display name of the
        /// mentioned entity.</param>
        /// <param name="mentioned">Provides more details on the mentioned
        /// entity.</param>
        public MessageActionsPayloadMention(int? id = default, string mentionText = default, MessageActionsPayloadFrom mentioned = default)
        {
            Id = id;
            MentionText = mentionText;
            Mentioned = mentioned;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets the id of the mentioned entity.
        /// </summary>
        /// <value>The mentioned entity ID.</value>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the plaintext display name of the mentioned entity.
        /// </summary>
        /// <value>The plaintext display name of the mentioned entity.</value>
        [JsonPropertyName("mentionText")]
        public string MentionText { get; set; }

        /// <summary>
        /// Gets or sets provides more details on the mentioned entity.
        /// </summary>
        /// <value>Details of the mentioned entity.</value>
        [JsonPropertyName("mentioned")]
        public MessageActionsPayloadFrom Mentioned { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}
