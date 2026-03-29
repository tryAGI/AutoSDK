//HintName: G.Models.ApplicationGraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplicationGraphsResponse
    {
        /// <summary>
        /// A list of Knowledge Graphs associated with the application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graph_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphsResponse" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// A list of Knowledge Graphs associated with the application.
        /// </param>
        public ApplicationGraphsResponse(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds)
        {
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphsResponse" /> class.
        /// </summary>
        public ApplicationGraphsResponse()
        {
        }
    }
}