//HintName: G.Models.TranslationStatusApiItemError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationStatusApiItemError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.TranslationStatusApiItemErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranslationStatusApiItemErrorErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemError" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="errorCode"></param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
        public TranslationStatusApiItemError(
            string language,
            global::G.TranslationStatusApiItemErrorErrorCode errorCode,
            global::G.TranslationStatusApiItemErrorStatus? status)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Status = status;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemError" /> class.
        /// </summary>
        public TranslationStatusApiItemError()
        {
        }
    }
}