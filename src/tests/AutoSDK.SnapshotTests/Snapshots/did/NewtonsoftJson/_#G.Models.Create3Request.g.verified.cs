//HintName: G.Models.Create3Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flattens intersection types into a single object type.<br/>
    /// This is useful for improving validation error messages and type display.
    /// </summary>
    public sealed partial class Create3Request
    {
        /// <summary>
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </summary>
        /// <example>my_expressive_video</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </summary>
        /// <example>public_dan@abcefg</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarId { get; set; } = default!;

        /// <summary>
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </summary>
        /// <example>snt_IIjpTS</example>
        [global::Newtonsoft.Json.JsonProperty("sentiment_id")]
        public string? SentimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.Create3RequestConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.AnyOf<global::G.Create3RequestBackgroundVariant1, global::G.Create3RequestBackgroundVariant2>? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </summary>
        /// <example>https://example.com/result.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.Create3RequestScriptVariant1, global::G.Create3RequestScriptVariant2> Script { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3Request" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </param>
        /// <param name="script"></param>
        /// <param name="name">
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </param>
        /// <param name="sentimentId">
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </param>
        /// <param name="config"></param>
        /// <param name="background"></param>
        /// <param name="userData"></param>
        /// <param name="persist"></param>
        /// <param name="resultUrl">
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </param>
        /// <param name="webhook"></param>
        public Create3Request(
            string avatarId,
            global::G.AnyOf<global::G.Create3RequestScriptVariant1, global::G.Create3RequestScriptVariant2> script,
            string? name,
            string? sentimentId,
            global::G.Create3RequestConfig? config,
            global::G.AnyOf<global::G.Create3RequestBackgroundVariant1, global::G.Create3RequestBackgroundVariant2>? background,
            string? userData,
            bool? persist,
            string? resultUrl,
            string? webhook)
        {
            this.Name = name;
            this.AvatarId = avatarId ?? throw new global::System.ArgumentNullException(nameof(avatarId));
            this.SentimentId = sentimentId;
            this.Config = config;
            this.Background = background;
            this.UserData = userData;
            this.Persist = persist;
            this.ResultUrl = resultUrl;
            this.Webhook = webhook;
            this.Script = script;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3Request" /> class.
        /// </summary>
        public Create3Request()
        {
        }
    }
}