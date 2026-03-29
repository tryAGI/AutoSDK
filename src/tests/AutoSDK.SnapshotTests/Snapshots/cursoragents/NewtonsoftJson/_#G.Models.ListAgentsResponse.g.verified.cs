//HintName: G.Models.ListAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsResponse
    {
        /// <summary>
        /// List of agents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListAgentsResponseAgent> Agents { get; set; } = default!;

        /// <summary>
        /// Cursor for fetching the next page of results<br/>
        /// Example: bc_def456
        /// </summary>
        /// <example>bc_def456</example>
        [global::Newtonsoft.Json.JsonProperty("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents">
        /// List of agents
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results<br/>
        /// Example: bc_def456
        /// </param>
        public ListAgentsResponse(
            global::System.Collections.Generic.IList<global::G.ListAgentsResponseAgent> agents,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        public ListAgentsResponse()
        {
        }
    }
}