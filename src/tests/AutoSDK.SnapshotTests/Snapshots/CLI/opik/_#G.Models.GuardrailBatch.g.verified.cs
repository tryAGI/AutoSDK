//HintName: G.Models.GuardrailBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Guardrail> Guardrails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBatch" /> class.
        /// </summary>
        /// <param name="guardrails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailBatch(
            global::System.Collections.Generic.IList<global::G.Guardrail> guardrails)
        {
            this.Guardrails = guardrails ?? throw new global::System.ArgumentNullException(nameof(guardrails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBatch" /> class.
        /// </summary>
        public GuardrailBatch()
        {
        }
    }
}