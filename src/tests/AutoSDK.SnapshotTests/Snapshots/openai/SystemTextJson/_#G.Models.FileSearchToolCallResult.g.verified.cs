//HintName: G.Models.FileSearchToolCallResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSearchToolCallResult
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The unique ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The relevance score of the file - a value between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// The text that was retrieved from the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCallResult" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
        /// <param name="fileId">
        /// The unique ID of the file.
        /// </param>
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="score">
        /// The relevance score of the file - a value between 0 and 1.
        /// </param>
        /// <param name="text">
        /// The text that was retrieved from the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchToolCallResult(
            object? attributes,
            string? fileId,
            string? filename,
            float? score,
            string? text)
        {
            this.Attributes = attributes;
            this.FileId = fileId;
            this.Filename = filename;
            this.Score = score;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCallResult" /> class.
        /// </summary>
        public FileSearchToolCallResult()
        {
        }
    }
}