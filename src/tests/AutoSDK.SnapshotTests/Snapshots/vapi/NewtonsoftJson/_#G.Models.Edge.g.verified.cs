//HintName: G.Models.Edge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Edge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public global::G.AIEdgeCondition? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// This is for metadata you want to store on the edge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="condition"></param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the edge.
        /// </param>
        public Edge(
            string from,
            string to,
            global::G.AIEdgeCondition? condition,
            object? metadata)
        {
            this.Condition = condition;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" /> class.
        /// </summary>
        public Edge()
        {
        }
    }
}