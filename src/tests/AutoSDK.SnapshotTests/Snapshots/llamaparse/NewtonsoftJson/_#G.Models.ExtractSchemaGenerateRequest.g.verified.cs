//HintName: G.Models.ExtractSchemaGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for generating an extraction schema.
    /// </summary>
    public sealed partial class ExtractSchemaGenerateRequest
    {
        /// <summary>
        /// Natural language description of the data structure to extract
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Optional file ID to analyze for schema generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// Optional schema to validate, refine, or extend during generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema")]
        public global::G.AnyOf<object, string, object>? DataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaGenerateRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Natural language description of the data structure to extract
        /// </param>
        /// <param name="fileId">
        /// Optional file ID to analyze for schema generation
        /// </param>
        /// <param name="dataSchema">
        /// Optional schema to validate, refine, or extend during generation
        /// </param>
        public ExtractSchemaGenerateRequest(
            string? prompt,
            global::System.Guid? fileId,
            global::G.AnyOf<object, string, object>? dataSchema)
        {
            this.Prompt = prompt;
            this.FileId = fileId;
            this.DataSchema = dataSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaGenerateRequest" /> class.
        /// </summary>
        public ExtractSchemaGenerateRequest()
        {
        }
    }
}