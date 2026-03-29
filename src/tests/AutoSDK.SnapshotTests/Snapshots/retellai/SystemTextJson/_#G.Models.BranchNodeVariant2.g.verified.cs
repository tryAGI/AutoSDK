//HintName: G.Models.BranchNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BranchNodeVariant2TypeJsonConverter))]
        public global::G.BranchNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElseEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ElseEdge ElseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchNodeVariant2" /> class.
        /// </summary>
        /// <param name="elseEdge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="edges"></param>
        /// <param name="finetuneTransitionExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchNodeVariant2(
            global::G.ElseEdge elseEdge,
            global::G.BranchNodeVariant2Type type,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchNodeVariant2" /> class.
        /// </summary>
        public BranchNodeVariant2()
        {
        }
    }
}