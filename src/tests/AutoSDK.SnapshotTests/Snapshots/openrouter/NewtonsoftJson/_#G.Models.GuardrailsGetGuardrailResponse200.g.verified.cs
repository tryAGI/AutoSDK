//HintName: G.Models.GuardrailsGetGuardrailResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsGetGuardrailResponse200
    {
        /// <summary>
        /// The guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailsIdGetResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsGetGuardrailResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// The guardrail
        /// </param>
        public GuardrailsGetGuardrailResponse200(
            global::G.GuardrailsIdGetResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsGetGuardrailResponse200" /> class.
        /// </summary>
        public GuardrailsGetGuardrailResponse200()
        {
        }
    }
}