//HintName: G.Models.ExtractDynamicVariablesNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractDynamicVariablesNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtractDynamicVariablesNodeVariant2TypeJsonConverter))]
        public global::G.ExtractDynamicVariablesNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnalysisData> Variables { get; set; }

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
        public global::G.ElseEdge? ElseEdge { get; set; }

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
        /// Initializes a new instance of the <see cref="ExtractDynamicVariablesNodeVariant2" /> class.
        /// </summary>
        /// <param name="variables"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="edges"></param>
        /// <param name="elseEdge"></param>
        /// <param name="finetuneTransitionExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractDynamicVariablesNodeVariant2(
            global::System.Collections.Generic.IList<global::G.AnalysisData> variables,
            global::G.ExtractDynamicVariablesNodeVariant2Type type,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::G.ElseEdge? elseEdge,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDynamicVariablesNodeVariant2" /> class.
        /// </summary>
        public ExtractDynamicVariablesNodeVariant2()
        {
        }
    }
}