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
        [global::Newtonsoft.Json.JsonProperty("guardrails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Guardrail> Guardrails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBatch" /> class.
        /// </summary>
        /// <param name="guardrails"></param>
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