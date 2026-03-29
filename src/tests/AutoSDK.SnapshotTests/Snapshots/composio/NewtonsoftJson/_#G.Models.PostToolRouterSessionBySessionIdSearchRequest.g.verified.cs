//HintName: G.Models.PostToolRouterSessionBySessionIdSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchRequest
    {
        /// <summary>
        /// List of search queries to execute in parallel. Up to 7 queries supported.<br/>
        /// Example: [{"use_case":"Send a slack message to a channel"}]
        /// </summary>
        /// <example>[{"use_case":"Send a slack message to a channel"}]</example>
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchRequestQuerie> Queries { get; set; } = default!;

        /// <summary>
        /// Optional model hint for search/planning behavior (e.g., "gpt-4o"). Ignored if invalid.<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequest" /> class.
        /// </summary>
        /// <param name="queries">
        /// List of search queries to execute in parallel. Up to 7 queries supported.<br/>
        /// Example: [{"use_case":"Send a slack message to a channel"}]
        /// </param>
        /// <param name="model">
        /// Optional model hint for search/planning behavior (e.g., "gpt-4o"). Ignored if invalid.<br/>
        /// Example: gpt-4o
        /// </param>
        public PostToolRouterSessionBySessionIdSearchRequest(
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchRequestQuerie> queries,
            string? model)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchRequest()
        {
        }
    }
}