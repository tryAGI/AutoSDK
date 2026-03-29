//HintName: G.Models.CreateClipRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipRequest2
    {
        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// Default Value: jack-Pt27VkP3hW<br/>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::Newtonsoft.Json.JsonProperty("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateClipRequestScriptVariant12, global::G.CreateClipRequestScriptVariant22> Script { get; set; } = default!;

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CreateClipRequestConfig2? Config { get; set; }

        /// <summary>
        /// Advanced presenter configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_config")]
        public global::G.CreateClipRequestPresenterConfig2? PresenterConfig { get; set; }

        /// <summary>
        /// Background color of the clip result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.CreateClipRequestBackground2? Background { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The URL of the clip video, if not provided use default destination.<br/>
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
        /// Initializes a new instance of the <see cref="CreateClipRequest2" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="presenterId">
        /// a selection from the list or provided driver ids.<br/>
        /// Default Value: jack-Pt27VkP3hW<br/>
        /// Example: jack-Pt27VkP3hW
        /// </param>
        /// <param name="driverId">
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Example: Vcq0R4a8F0
        /// </param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="presenterConfig">
        /// Advanced presenter configuration options.
        /// </param>
        /// <param name="background">
        /// Background color of the clip result
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the clip
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        public CreateClipRequest2(
            global::G.AnyOf<global::G.CreateClipRequestScriptVariant12, global::G.CreateClipRequestScriptVariant22> script,
            string? presenterId,
            string? driverId,
            global::G.CreateClipRequestConfig2? config,
            global::G.CreateClipRequestPresenterConfig2? presenterConfig,
            global::G.CreateClipRequestBackground2? background,
            string? userData,
            string? name,
            string? webhook,
            string? resultUrl)
        {
            this.PresenterId = presenterId;
            this.DriverId = driverId;
            this.Script = script;
            this.Config = config;
            this.PresenterConfig = presenterConfig;
            this.Background = background;
            this.UserData = userData;
            this.Name = name;
            this.Webhook = webhook;
            this.ResultUrl = resultUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequest2" /> class.
        /// </summary>
        public CreateClipRequest2()
        {
        }
    }
}