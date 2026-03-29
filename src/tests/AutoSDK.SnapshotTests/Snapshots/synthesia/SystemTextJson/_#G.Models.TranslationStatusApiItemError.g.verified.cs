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
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationStatusApiItemErrorStatusJsonConverter))]
        public global::G.TranslationStatusApiItemErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationStatusApiItemErrorErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslationStatusApiItemErrorErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationStatusApiItemError" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="errorCode"></param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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