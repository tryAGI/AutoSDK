//HintName: G.Models.TranslationStatusApiItemSuccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationStatusApiItemSuccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationStatusApiItemSuccessStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslationStatusApiItemSuccessStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationStatusApiItemSuccessStepJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslationStatusApiItemSuccessStep Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemSuccess" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="status"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationStatusApiItemSuccess(
            string language,
            global::G.TranslationStatusApiItemSuccessStatus status,
            global::G.TranslationStatusApiItemSuccessStep step)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Status = status;
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemSuccess" /> class.
        /// </summary>
        public TranslationStatusApiItemSuccess()
        {
        }
    }
}