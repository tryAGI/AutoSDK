//HintName: G.Models.ExtractJobCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating an extraction job.
    /// </summary>
    public sealed partial class ExtractJobCreateParams
    {
        /// <summary>
        /// The ID of the file to extract from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The JSON schema to use for extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreateParams" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to extract from
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for extraction
        /// </param>
        public ExtractJobCreateParams(
            string fileId,
            object jsonSchema)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreateParams" /> class.
        /// </summary>
        public ExtractJobCreateParams()
        {
        }
    }
}