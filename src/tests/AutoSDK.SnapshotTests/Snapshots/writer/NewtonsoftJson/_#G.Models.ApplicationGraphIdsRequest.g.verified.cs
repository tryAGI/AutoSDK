//HintName: G.Models.ApplicationGraphIdsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplicationGraphIdsRequest
    {
        /// <summary>
        /// A list of Knowledge Graph IDs to associate with the application. Note that this will replace the existing list of Knowledge Graphs associated with the application, not add to it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graph_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphIdsRequest" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// A list of Knowledge Graph IDs to associate with the application. Note that this will replace the existing list of Knowledge Graphs associated with the application, not add to it.
        /// </param>
        public ApplicationGraphIdsRequest(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds)
        {
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphIdsRequest" /> class.
        /// </summary>
        public ApplicationGraphIdsRequest()
        {
        }
    }
}