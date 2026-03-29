//HintName: G.Models.GuardrailsUpdateGuardrailResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsUpdateGuardrailResponse200
    {
        /// <summary>
        /// The updated guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailsIdPatchResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsUpdateGuardrailResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// The updated guardrail
        /// </param>
        public GuardrailsUpdateGuardrailResponse200(
            global::G.GuardrailsIdPatchResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsUpdateGuardrailResponse200" /> class.
        /// </summary>
        public GuardrailsUpdateGuardrailResponse200()
        {
        }
    }
}