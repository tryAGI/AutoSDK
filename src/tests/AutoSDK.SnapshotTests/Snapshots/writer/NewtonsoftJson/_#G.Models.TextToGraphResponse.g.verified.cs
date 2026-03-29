//HintName: G.Models.TextToGraphResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToGraphResponse
    {
        /// <summary>
        /// The graph structure generated from the input text, represented by a string array of entities and relationships.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graph", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Graph { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToGraphResponse" /> class.
        /// </summary>
        /// <param name="graph">
        /// The graph structure generated from the input text, represented by a string array of entities and relationships.
        /// </param>
        public TextToGraphResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> graph)
        {
            this.Graph = graph ?? throw new global::System.ArgumentNullException(nameof(graph));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToGraphResponse" /> class.
        /// </summary>
        public TextToGraphResponse()
        {
        }
    }
}