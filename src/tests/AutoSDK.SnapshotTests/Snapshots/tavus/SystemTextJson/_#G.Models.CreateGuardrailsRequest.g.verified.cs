//HintName: G.Models.CreateGuardrailsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGuardrailsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_name")]
        public string? GuardrailsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_prompt")]
        public string? GuardrailsPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailsRequest" /> class.
        /// </summary>
        /// <param name="guardrailsName"></param>
        /// <param name="guardrailsPrompt"></param>
        /// <param name="modality"></param>
        /// <param name="callbackUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailsRequest(
            string? guardrailsName,
            string? guardrailsPrompt,
            string? modality,
            string? callbackUrl)
        {
            this.GuardrailsName = guardrailsName;
            this.GuardrailsPrompt = guardrailsPrompt;
            this.Modality = modality;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailsRequest" /> class.
        /// </summary>
        public CreateGuardrailsRequest()
        {
        }
    }
}