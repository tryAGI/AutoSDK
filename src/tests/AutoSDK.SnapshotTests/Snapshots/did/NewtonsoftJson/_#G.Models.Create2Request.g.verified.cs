//HintName: G.Models.Create2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create2Request
    {
        /// <summary>
        /// The avatar that will be used to create the scene.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.Create2RequestScriptText, global::G.Create2RequestScriptAudio> Script { get; set; } = default!;

        /// <summary>
        /// A webhook URL for sending the payload including scene details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the scene, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.Create2RequestConfig? Config { get; set; }

        /// <summary>
        /// Background color of the scene result, can only be used for avatars with green screen background
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.Create2RequestBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2Request" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// The avatar that will be used to create the scene.
        /// </param>
        /// <param name="script"></param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including scene details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the scene
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the scene, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="background">
        /// Background color of the scene result, can only be used for avatars with green screen background
        /// </param>
        public Create2Request(
            string avatarId,
            global::G.AnyOf<global::G.Create2RequestScriptText, global::G.Create2RequestScriptAudio> script,
            string? webhook,
            string? userData,
            string? name,
            string? resultUrl,
            global::G.Create2RequestConfig? config,
            global::G.Create2RequestBackground? background)
        {
            this.AvatarId = avatarId ?? throw new global::System.ArgumentNullException(nameof(avatarId));
            this.Script = script;
            this.Webhook = webhook;
            this.UserData = userData;
            this.Name = name;
            this.ResultUrl = resultUrl;
            this.Config = config;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2Request" /> class.
        /// </summary>
        public Create2Request()
        {
        }
    }
}