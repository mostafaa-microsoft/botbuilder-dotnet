﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// Information about the file to be uploaded.
    /// </summary>
    public class FileUploadInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadInfo"/> class.
        /// </summary>
        public FileUploadInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadInfo"/> class.
        /// </summary>
        /// <param name="name">Name of the file.</param>
        /// <param name="uploadUrl">URL to an upload session that the bot can
        /// use to set the file contents.</param>
        /// <param name="contentUrl">URL to file.</param>
        /// <param name="uniqueId">ID that uniquely identifies the
        /// file.</param>
        /// <param name="fileType">Type of the file.</param>
        public FileUploadInfo(string name = default, string uploadUrl = default, string contentUrl = default, string uniqueId = default, string fileType = default)
        {
            Name = name;
            UploadUrl = uploadUrl;
            ContentUrl = contentUrl;
            UniqueId = uniqueId;
            FileType = fileType;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets URL to an upload session that the bot can use to set
        /// the file contents.
        /// </summary>
        /// <value>The URL to an upload session that the bot can use to set the file contents.</value>
        [JsonPropertyName("uploadUrl")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string UploadUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        /// Gets or sets URL to file.
        /// </summary>
        /// <value>The URL to the file content.</value>
        [JsonPropertyName("contentUrl")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string ContentUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        /// Gets or sets ID that uniquely identifies the file.
        /// </summary>
        /// <value>The unique file ID.</value>
        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or sets type of the file.
        /// </summary>
        /// <value>The type of the file.</value>
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}
