//HintName: G.Models.CreateTalkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkRequest
    {
        /// <summary>
        /// The URL of the source image to be animated by the driver video, or a selection from the list of provided<br/>
        /// studio actors.<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </summary>
        /// <example>https://path.to.directory/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateTalkRequestScriptVariant1, global::G.CreateTalkRequestScriptVariant2> Script { get; set; } = default!;

        /// <summary>
        /// Advanced configuration options
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CreateTalkRequestConfig? Config { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the talk response and webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the talk video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The URL of the talk video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </summary>
        /// <example>https://path.to.directory/</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequest" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video, or a selection from the list of provided<br/>
        /// studio actors.<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </param>
        /// <param name="config">
        /// Advanced configuration options
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the talk response and webhook
        /// </param>
        /// <param name="name">
        /// The name of the talk video
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the talk video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        public CreateTalkRequest(
            global::G.AnyOf<global::G.CreateTalkRequestScriptVariant1, global::G.CreateTalkRequestScriptVariant2> script,
            string? sourceUrl,
            global::G.CreateTalkRequestConfig? config,
            string? userData,
            string? name,
            string? webhook,
            string? resultUrl)
        {
            this.SourceUrl = sourceUrl;
            this.Script = script;
            this.Config = config;
            this.UserData = userData;
            this.Name = name;
            this.Webhook = webhook;
            this.ResultUrl = resultUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequest" /> class.
        /// </summary>
        public CreateTalkRequest()
        {
        }
    }
}