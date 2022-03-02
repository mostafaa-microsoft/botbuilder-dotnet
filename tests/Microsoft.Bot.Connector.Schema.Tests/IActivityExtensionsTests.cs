﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Xunit;
using static Microsoft.Bot.Connector.Schema.Tests.ActivityTestData;

namespace Microsoft.Bot.Connector.Schema.Tests
{
    public class IActivityExtensionsTests
    {
        [Fact]
        public void SetAndGetLocaleOnConversationUpdate()
        {
            var sut = Activity.CreateConversationUpdateActivity();

            Assert.Null(sut.GetLocale());
            sut.SetLocale("en-UK");
            Assert.Equal("en-UK", sut.GetLocale());
        }

        [Theory]
        [ClassData(typeof(MentionsData))]
        public void DetectMentionedId(List<Entity> entities, bool expectsMention)
        {
            var message = new Activity()
            {
                Type = ActivityTypes.Message,
                Entities = entities,
            };
            var mentionsId = ActivityExtensions.MentionsId(message, "ChannelAccountId");

            Assert.Equal(expectsMention, mentionsId);
        }

        [Theory]
        [ClassData(typeof(MentionsData))]
        public void DetectsMentionedRecipient(List<Entity> entities, bool expectsMention)
        {
            var message = new Activity()
            {
                Type = ActivityTypes.Message,
                Entities = entities,
                Recipient = new ChannelAccount
                {
                    Id = "ChannelAccountId",
                    Name = "ChannelAccountName",
                    Properties = new { Name = "Value" }.ToJsonElements(),
                    Role = "ChannelAccountRole",
                }
            };

            var mentionsRecipient = message.MentionsRecipient();

            Assert.Equal(expectsMention, mentionsRecipient);
        }
    }
}
