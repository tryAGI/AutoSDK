//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra parameters used when streaming the response.
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions
    {
        /// <summary>
        /// Whether to include tokens used in the stream response objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// Whether to include tokens used in the stream response objects.
        /// </param>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions()
        {
        }
    }
}