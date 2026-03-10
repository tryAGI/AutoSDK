//HintName: G.Models.ResponseFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for filtering tool responses before they are visible to the agent.
    /// </summary>
    public sealed partial class ResponseFilter
    {
        /// <summary>
        /// Controls how tool responses are filtered. 'all' returns entire response, 'allow' returns only specified paths.<br/>
        /// Default Value: all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.ResponseFilterMode? Mode { get; set; }

        /// <summary>
        /// Dot notation paths to include when mode is 'allow' (e.g., ['ticket.id', 'ticket.status']).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<string>? Filters { get; set; }

        /// <summary>
        /// Content type for response filtering. Only 'application/json' responses are filtered.<br/>
        /// Default Value: application/json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        /// <param name="mode">
        /// Controls how tool responses are filtered. 'all' returns entire response, 'allow' returns only specified paths.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="filters">
        /// Dot notation paths to include when mode is 'allow' (e.g., ['ticket.id', 'ticket.status']).
        /// </param>
        /// <param name="contentType">
        /// Content type for response filtering. Only 'application/json' responses are filtered.<br/>
        /// Default Value: application/json
        /// </param>
        public ResponseFilter(
            global::G.ResponseFilterMode? mode,
            global::System.Collections.Generic.IList<string>? filters,
            string? contentType)
        {
            this.Mode = mode;
            this.Filters = filters;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        public ResponseFilter()
        {
        }
    }
}