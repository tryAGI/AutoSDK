﻿//HintName: G.Models.ChatCompletionRequestMessageContentPartFileFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartFileFile
    {
        /// <summary>
        /// The name of the file, used when passing the file to the model as a <br/>
        /// string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The base64 encoded file data, used when passing the file to the model <br/>
        /// as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// The ID of an uploaded file to use as input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFileFile" /> class.
        /// </summary>
        /// <param name="filename">
        /// The name of the file, used when passing the file to the model as a <br/>
        /// string.
        /// </param>
        /// <param name="fileData">
        /// The base64 encoded file data, used when passing the file to the model <br/>
        /// as a string.
        /// </param>
        /// <param name="fileId">
        /// The ID of an uploaded file to use as input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartFileFile(
            string? filename,
            string? fileData,
            string? fileId)
        {
            this.Filename = filename;
            this.FileData = fileData;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFileFile" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartFileFile()
        {
        }
    }
}