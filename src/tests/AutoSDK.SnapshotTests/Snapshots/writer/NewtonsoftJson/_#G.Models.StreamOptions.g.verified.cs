//HintName: G.Models.StreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional options for streaming.
    /// </summary>
    public sealed partial class StreamOptions
    {
        /// <summary>
        /// Indicate whether to include usage information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeUsage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// Indicate whether to include usage information.
        /// </param>
        public StreamOptions(
            bool includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        public StreamOptions()
        {
        }
    }
}