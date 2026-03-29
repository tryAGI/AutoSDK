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
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranslationStatusApiItemSuccessStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranslationStatusApiItemSuccessStep Step { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemSuccess" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="status"></param>
        /// <param name="step"></param>
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