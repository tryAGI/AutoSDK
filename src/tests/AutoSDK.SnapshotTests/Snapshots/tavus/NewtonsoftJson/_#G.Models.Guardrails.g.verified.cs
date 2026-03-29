//HintName: G.Models.Guardrails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Guardrails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_id")]
        public string? GuardrailsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_name")]
        public string? GuardrailsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_prompt")]
        public string? GuardrailsPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrails" /> class.
        /// </summary>
        /// <param name="guardrailsId"></param>
        /// <param name="guardrailsName"></param>
        /// <param name="guardrailsPrompt"></param>
        /// <param name="modality"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public Guardrails(
            string? guardrailsId,
            string? guardrailsName,
            string? guardrailsPrompt,
            string? modality,
            string? callbackUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.GuardrailsId = guardrailsId;
            this.GuardrailsName = guardrailsName;
            this.GuardrailsPrompt = guardrailsPrompt;
            this.Modality = modality;
            this.CallbackUrl = callbackUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrails" /> class.
        /// </summary>
        public Guardrails()
        {
        }
    }
}