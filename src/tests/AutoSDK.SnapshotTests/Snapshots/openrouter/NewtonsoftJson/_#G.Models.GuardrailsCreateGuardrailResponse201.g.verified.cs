//HintName: G.Models.GuardrailsCreateGuardrailResponse201.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsCreateGuardrailResponse201
    {
        /// <summary>
        /// The created guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailsPostResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsCreateGuardrailResponse201" /> class.
        /// </summary>
        /// <param name="data">
        /// The created guardrail
        /// </param>
        public GuardrailsCreateGuardrailResponse201(
            global::G.GuardrailsPostResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsCreateGuardrailResponse201" /> class.
        /// </summary>
        public GuardrailsCreateGuardrailResponse201()
        {
        }
    }
}