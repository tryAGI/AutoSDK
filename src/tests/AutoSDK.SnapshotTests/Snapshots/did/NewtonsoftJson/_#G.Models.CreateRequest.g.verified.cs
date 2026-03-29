//HintName: G.Models.CreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest
    {
        /// <summary>
        /// The URL of the source video to be translated.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// The languages into which the video will be translated. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Languages { get; set; } = default!;

        /// <summary>
        /// The language spoken in the original video uploaded. Using this feature might help mitigate STT errors. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the translation response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The result url of the video, if not provided use default destination. supports s3 signed urls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source video to be translated.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="languages">
        /// The languages into which the video will be translated. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </param>
        /// <param name="sourceLanguage">
        /// The language spoken in the original video uploaded. Using this feature might help mitigate STT errors. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the translation response and webhook.
        /// </param>
        /// <param name="resultUrl">
        /// The result url of the video, if not provided use default destination. supports s3 signed urls.
        /// </param>
        public CreateRequest(
            string sourceUrl,
            global::System.Collections.Generic.IList<string> languages,
            string? sourceLanguage,
            string? webhook,
            string? userData,
            string? resultUrl)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.SourceLanguage = sourceLanguage;
            this.Webhook = webhook;
            this.UserData = userData;
            this.ResultUrl = resultUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        public CreateRequest()
        {
        }
    }
}