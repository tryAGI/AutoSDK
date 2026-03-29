//HintName: G.Models.GetSpansSpanKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by span kind(s). Values: LLM, CHAIN, TOOL, RETRIEVER, EMBEDDING, AGENT, RERANKER, GUARDRAIL, EVALUATOR, UNKNOWN
    /// </summary>
    public sealed partial class GetSpansSpanKind
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}