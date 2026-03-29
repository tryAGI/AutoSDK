//HintName: G.Models.GraphFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses Knowledge Graphs as context for responses.
    /// </summary>
    public sealed partial class GraphFunction
    {
        /// <summary>
        /// A description of the graph content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of graph IDs to use in the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graph_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; } = default!;

        /// <summary>
        /// Boolean to indicate whether to include subqueries in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subqueries", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Subqueries { get; set; } = default!;

        /// <summary>
        /// Configuration options for Knowledge Graph queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_config")]
        public global::G.GraphQueryConfig? QueryConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFunction" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// An array of graph IDs to use in the tool.
        /// </param>
        /// <param name="subqueries">
        /// Boolean to indicate whether to include subqueries in the response.
        /// </param>
        /// <param name="description">
        /// A description of the graph content.
        /// </param>
        /// <param name="queryConfig">
        /// Configuration options for Knowledge Graph queries.
        /// </param>
        public GraphFunction(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            bool subqueries,
            string? description,
            global::G.GraphQueryConfig? queryConfig)
        {
            this.Description = description;
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
            this.Subqueries = subqueries;
            this.QueryConfig = queryConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFunction" /> class.
        /// </summary>
        public GraphFunction()
        {
        }
    }
}