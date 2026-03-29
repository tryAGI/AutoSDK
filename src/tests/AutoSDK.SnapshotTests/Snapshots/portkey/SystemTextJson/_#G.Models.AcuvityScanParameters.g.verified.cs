//HintName: G.Models.AcuvityScanParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcuvityScanParameters
    {
        /// <summary>
        /// Enable prompt injection detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection")]
        public bool? PromptInjection { get; set; }

        /// <summary>
        /// Threshold for prompt injection detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection_threshold")]
        public double? PromptInjectionThreshold { get; set; }

        /// <summary>
        /// Enable toxicity detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxic")]
        public bool? Toxic { get; set; }

        /// <summary>
        /// Threshold for toxicity detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxic_threshold")]
        public double? ToxicThreshold { get; set; }

        /// <summary>
        /// Enable jailbreak detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jail_break")]
        public bool? JailBreak { get; set; }

        /// <summary>
        /// Threshold for jailbreak detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jail_break_threshold")]
        public double? JailBreakThreshold { get; set; }

        /// <summary>
        /// Enable malicious URL detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("malicious_url")]
        public bool? MaliciousUrl { get; set; }

        /// <summary>
        /// Threshold for malicious URL detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("malicious_url_threshold")]
        public double? MaliciousUrlThreshold { get; set; }

        /// <summary>
        /// Enable bias detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biased")]
        public bool? Biased { get; set; }

        /// <summary>
        /// Threshold for bias detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biased_threshold")]
        public double? BiasedThreshold { get; set; }

        /// <summary>
        /// Enable harmful content detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harmful")]
        public bool? Harmful { get; set; }

        /// <summary>
        /// Threshold for harmful content detection<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harmful_threshold")]
        public double? HarmfulThreshold { get; set; }

        /// <summary>
        /// Enable language check<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public bool? Language { get; set; }

        /// <summary>
        /// Language to check<br/>
        /// Default Value: english
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_values")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter))]
        public global::G.AcuvityScanParametersLanguageValues? LanguageValues { get; set; }

        /// <summary>
        /// Enable PII detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii")]
        public bool? Pii { get; set; }

        /// <summary>
        /// Enable PII redaction<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_redact")]
        public bool? PiiRedact { get; set; }

        /// <summary>
        /// PII categories to detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_categories")]
        public global::System.Collections.Generic.IList<global::G.AcuvityScanParametersPiiCategorie>? PiiCategories { get; set; }

        /// <summary>
        /// Enable secrets detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public bool? Secrets { get; set; }

        /// <summary>
        /// Enable secrets redaction<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets_redact")]
        public bool? SecretsRedact { get; set; }

        /// <summary>
        /// Secret categories to detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets_categories")]
        public global::System.Collections.Generic.IList<global::G.AcuvityScanParametersSecretsCategorie>? SecretsCategories { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcuvityScanParameters" /> class.
        /// </summary>
        /// <param name="promptInjection">
        /// Enable prompt injection detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="promptInjectionThreshold">
        /// Threshold for prompt injection detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="toxic">
        /// Enable toxicity detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="toxicThreshold">
        /// Threshold for toxicity detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="jailBreak">
        /// Enable jailbreak detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="jailBreakThreshold">
        /// Threshold for jailbreak detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="maliciousUrl">
        /// Enable malicious URL detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maliciousUrlThreshold">
        /// Threshold for malicious URL detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="biased">
        /// Enable bias detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="biasedThreshold">
        /// Threshold for bias detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="harmful">
        /// Enable harmful content detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="harmfulThreshold">
        /// Threshold for harmful content detection<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="language">
        /// Enable language check<br/>
        /// Default Value: true
        /// </param>
        /// <param name="languageValues">
        /// Language to check<br/>
        /// Default Value: english
        /// </param>
        /// <param name="pii">
        /// Enable PII detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="piiRedact">
        /// Enable PII redaction<br/>
        /// Default Value: false
        /// </param>
        /// <param name="piiCategories">
        /// PII categories to detect
        /// </param>
        /// <param name="secrets">
        /// Enable secrets detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="secretsRedact">
        /// Enable secrets redaction<br/>
        /// Default Value: false
        /// </param>
        /// <param name="secretsCategories">
        /// Secret categories to detect
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcuvityScanParameters(
            bool? promptInjection,
            double? promptInjectionThreshold,
            bool? toxic,
            double? toxicThreshold,
            bool? jailBreak,
            double? jailBreakThreshold,
            bool? maliciousUrl,
            double? maliciousUrlThreshold,
            bool? biased,
            double? biasedThreshold,
            bool? harmful,
            double? harmfulThreshold,
            bool? language,
            global::G.AcuvityScanParametersLanguageValues? languageValues,
            bool? pii,
            bool? piiRedact,
            global::System.Collections.Generic.IList<global::G.AcuvityScanParametersPiiCategorie>? piiCategories,
            bool? secrets,
            bool? secretsRedact,
            global::System.Collections.Generic.IList<global::G.AcuvityScanParametersSecretsCategorie>? secretsCategories,
            double? timeout)
        {
            this.PromptInjection = promptInjection;
            this.PromptInjectionThreshold = promptInjectionThreshold;
            this.Toxic = toxic;
            this.ToxicThreshold = toxicThreshold;
            this.JailBreak = jailBreak;
            this.JailBreakThreshold = jailBreakThreshold;
            this.MaliciousUrl = maliciousUrl;
            this.MaliciousUrlThreshold = maliciousUrlThreshold;
            this.Biased = biased;
            this.BiasedThreshold = biasedThreshold;
            this.Harmful = harmful;
            this.HarmfulThreshold = harmfulThreshold;
            this.Language = language;
            this.LanguageValues = languageValues;
            this.Pii = pii;
            this.PiiRedact = piiRedact;
            this.PiiCategories = piiCategories;
            this.Secrets = secrets;
            this.SecretsRedact = secretsRedact;
            this.SecretsCategories = secretsCategories;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcuvityScanParameters" /> class.
        /// </summary>
        public AcuvityScanParameters()
        {
        }
    }
}