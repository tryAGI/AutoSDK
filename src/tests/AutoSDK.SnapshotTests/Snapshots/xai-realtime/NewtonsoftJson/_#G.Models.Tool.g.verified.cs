//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool definition for the Realtime session.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// Tool type: function, file_search, web_search, or x_search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Function name (for function tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Function description (for function tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters JSON Schema (for function tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Collection IDs (for file_search tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_ids")]
        public global::System.Collections.Generic.IList<string>? VectorStoreIds { get; set; }

        /// <summary>
        /// Max search results (for file_search tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// Allowed X handles (for x_search tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_x_handles")]
        public global::System.Collections.Generic.IList<string>? AllowedXHandles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="type">
        /// Tool type: function, file_search, web_search, or x_search.
        /// </param>
        /// <param name="name">
        /// Function name (for function tools).
        /// </param>
        /// <param name="description">
        /// Function description (for function tools).
        /// </param>
        /// <param name="parameters">
        /// Function parameters JSON Schema (for function tools).
        /// </param>
        /// <param name="vectorStoreIds">
        /// Collection IDs (for file_search tools).
        /// </param>
        /// <param name="maxNumResults">
        /// Max search results (for file_search tools).
        /// </param>
        /// <param name="allowedXHandles">
        /// Allowed X handles (for x_search tools).
        /// </param>
        public Tool(
            string? type,
            string? name,
            string? description,
            object? parameters,
            global::System.Collections.Generic.IList<string>? vectorStoreIds,
            int? maxNumResults,
            global::System.Collections.Generic.IList<string>? allowedXHandles)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.VectorStoreIds = vectorStoreIds;
            this.MaxNumResults = maxNumResults;
            this.AllowedXHandles = allowedXHandles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}