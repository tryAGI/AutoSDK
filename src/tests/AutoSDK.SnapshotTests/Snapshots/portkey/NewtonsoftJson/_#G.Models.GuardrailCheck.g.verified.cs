//HintName: G.Models.GuardrailCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailCheck
    {
        /// <summary>
        /// Identifier of the guardrail check type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GuardrailCheckIdJsonConverter))]
        public global::G.GuardrailCheckId Id { get; set; } = default!;

        /// <summary>
        /// Configuration parameters specific to the check type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.OneOf<global::G.JWTParameters, global::G.ModelWhitelistParameters, global::G.RegexMatchParameters, global::G.SentenceCountParameters, global::G.WordCountParameters, global::G.CharacterCountParameters, global::G.JSONSchemaParameters, global::G.JSONKeysParameters, global::G.ContainsParameters, global::G.ValidUrlsParameters, global::G.ContainsCodeParameters, global::G.WebhookParameters, global::G.EndsWithParameters, global::G.UppercaseParameters, global::G.RequiredMetadataKeysParameters, global::G.AllowedRequestTypesParameters, global::G.SydeGuardParameters, global::G.AporiaParameters, global::G.PillarScanParameters, global::G.PatronusParameters, global::G.PatronusCustomParameters, global::G.PortkeyModerationParameters, global::G.PortkeyLanguageParameters, global::G.PortkeyPIIParameters, global::G.MistralModerationParameters, global::G.BedrockGuardParameters, global::G.PromptfooParameters, global::G.AcuvityScanParameters, global::G.AzureContentSafetyParameters, global::G.AzurePIIParameters, global::G.PANWPrismaParameters, global::G.BasicParameters>? Parameters { get; set; }

        /// <summary>
        /// Custom name for this specific check instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether this check is enabled<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailCheck" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the guardrail check type
        /// </param>
        /// <param name="parameters">
        /// Configuration parameters specific to the check type
        /// </param>
        /// <param name="name">
        /// Custom name for this specific check instance
        /// </param>
        /// <param name="isEnabled">
        /// Whether this check is enabled<br/>
        /// Default Value: true
        /// </param>
        public GuardrailCheck(
            global::G.GuardrailCheckId id,
            global::G.OneOf<global::G.JWTParameters, global::G.ModelWhitelistParameters, global::G.RegexMatchParameters, global::G.SentenceCountParameters, global::G.WordCountParameters, global::G.CharacterCountParameters, global::G.JSONSchemaParameters, global::G.JSONKeysParameters, global::G.ContainsParameters, global::G.ValidUrlsParameters, global::G.ContainsCodeParameters, global::G.WebhookParameters, global::G.EndsWithParameters, global::G.UppercaseParameters, global::G.RequiredMetadataKeysParameters, global::G.AllowedRequestTypesParameters, global::G.SydeGuardParameters, global::G.AporiaParameters, global::G.PillarScanParameters, global::G.PatronusParameters, global::G.PatronusCustomParameters, global::G.PortkeyModerationParameters, global::G.PortkeyLanguageParameters, global::G.PortkeyPIIParameters, global::G.MistralModerationParameters, global::G.BedrockGuardParameters, global::G.PromptfooParameters, global::G.AcuvityScanParameters, global::G.AzureContentSafetyParameters, global::G.AzurePIIParameters, global::G.PANWPrismaParameters, global::G.BasicParameters>? parameters,
            string? name,
            bool? isEnabled)
        {
            this.Id = id;
            this.Parameters = parameters;
            this.Name = name;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailCheck" /> class.
        /// </summary>
        public GuardrailCheck()
        {
        }
    }
}