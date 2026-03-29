//HintName: G.Models.ExtractV2SchemaGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for generating an extraction schema.
    /// </summary>
    public sealed partial class ExtractV2SchemaGenerateRequest
    {
        /// <summary>
        /// Name for the generated configuration (auto-generated if omitted)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Natural language description of the data structure to extract
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Optional file ID to analyze for schema generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Optional schema to validate, refine, or extend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema")]
        public object? DataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaGenerateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the generated configuration (auto-generated if omitted)
        /// </param>
        /// <param name="prompt">
        /// Natural language description of the data structure to extract
        /// </param>
        /// <param name="fileId">
        /// Optional file ID to analyze for schema generation
        /// </param>
        /// <param name="dataSchema">
        /// Optional schema to validate, refine, or extend
        /// </param>
        public ExtractV2SchemaGenerateRequest(
            string? name,
            string? prompt,
            string? fileId,
            object? dataSchema)
        {
            this.Name = name;
            this.Prompt = prompt;
            this.FileId = fileId;
            this.DataSchema = dataSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaGenerateRequest" /> class.
        /// </summary>
        public ExtractV2SchemaGenerateRequest()
        {
        }
    }
}