//HintName: G.Models.UpsertVideoTranslationsApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertVideoTranslationsApiRequest
    {
        /// <summary>
        /// List of language codes to translate the video into. See https://docs.synthesia.io/docs/supported-languages for accepted values.<br/>
        /// Example: [es, fr]
        /// </summary>
        /// <example>[es, fr]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLanguages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLanguages { get; set; }

        /// <summary>
        /// If true, only the script is translated without regenerating the video. Cannot be combined with autoGenerate.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translateScriptOnly")]
        public bool? TranslateScriptOnly { get; set; }

        /// <summary>
        /// Automatically generate the translated video after translation completes. Set to 'private' to generate without sharing publicly, or 'public' to generate and publish immediately.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoGenerate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter))]
        public global::G.UpsertVideoTranslationsApiRequestAutoGenerate? AutoGenerate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsApiRequest" /> class.
        /// </summary>
        /// <param name="targetLanguages">
        /// List of language codes to translate the video into. See https://docs.synthesia.io/docs/supported-languages for accepted values.<br/>
        /// Example: [es, fr]
        /// </param>
        /// <param name="translateScriptOnly">
        /// If true, only the script is translated without regenerating the video. Cannot be combined with autoGenerate.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoGenerate">
        /// Automatically generate the translated video after translation completes. Set to 'private' to generate without sharing publicly, or 'public' to generate and publish immediately.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertVideoTranslationsApiRequest(
            global::System.Collections.Generic.IList<string> targetLanguages,
            bool? translateScriptOnly,
            global::G.UpsertVideoTranslationsApiRequestAutoGenerate? autoGenerate)
        {
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.TranslateScriptOnly = translateScriptOnly;
            this.AutoGenerate = autoGenerate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsApiRequest" /> class.
        /// </summary>
        public UpsertVideoTranslationsApiRequest()
        {
        }
    }
}