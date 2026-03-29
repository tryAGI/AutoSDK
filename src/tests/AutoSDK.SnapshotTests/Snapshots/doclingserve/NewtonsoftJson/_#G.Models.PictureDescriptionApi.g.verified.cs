//HintName: G.Models.PictureDescriptionApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PictureDescriptionApi
    {
        /// <summary>
        /// Endpoint which accepts openai-api compatible requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Headers used for calling the API endpoint. For example, it could include authentication headers.<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Model parameters.<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Timeout for the API request.<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Maximum number of concurrent requests to the API.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concurrency")]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Prompt used when calling the vision-language model.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Only describe pictures whose predicted class is in this allow-list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_allow")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationAllow { get; set; }

        /// <summary>
        /// Do not describe pictures whose predicted class is in this deny-list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_deny")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationDeny { get; set; }

        /// <summary>
        /// Minimum classification confidence required before a picture can be described.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_min_confidence")]
        public double? ClassificationMinConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionApi" /> class.
        /// </summary>
        /// <param name="url">
        /// Endpoint which accepts openai-api compatible requests.
        /// </param>
        /// <param name="headers">
        /// Headers used for calling the API endpoint. For example, it could include authentication headers.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="params">
        /// Model parameters.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="timeout">
        /// Timeout for the API request.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="concurrency">
        /// Maximum number of concurrent requests to the API.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="prompt">
        /// Prompt used when calling the vision-language model.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </param>
        /// <param name="classificationAllow">
        /// Only describe pictures whose predicted class is in this allow-list.
        /// </param>
        /// <param name="classificationDeny">
        /// Do not describe pictures whose predicted class is in this deny-list.
        /// </param>
        /// <param name="classificationMinConfidence">
        /// Minimum classification confidence required before a picture can be described.<br/>
        /// Default Value: 0F
        /// </param>
        public PictureDescriptionApi(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? @params,
            double? timeout,
            int? concurrency,
            string? prompt,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationAllow,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationDeny,
            double? classificationMinConfidence)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Params = @params;
            this.Timeout = timeout;
            this.Concurrency = concurrency;
            this.Prompt = prompt;
            this.ClassificationAllow = classificationAllow;
            this.ClassificationDeny = classificationDeny;
            this.ClassificationMinConfidence = classificationMinConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionApi" /> class.
        /// </summary>
        public PictureDescriptionApi()
        {
        }
    }
}