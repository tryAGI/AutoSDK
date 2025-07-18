﻿//HintName: G.Models.CreateContainerFileBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContainerFileBody
    {
        /// <summary>
        /// Name of the file to create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The File object (not file name) to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The File object (not file name) to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerFileBody" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Name of the file to create.
        /// </param>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        public CreateContainerFileBody(
            string? fileId,
            byte[]? file,
            string? filename)
        {
            this.FileId = fileId;
            this.File = file;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerFileBody" /> class.
        /// </summary>
        public CreateContainerFileBody()
        {
        }
    }
}