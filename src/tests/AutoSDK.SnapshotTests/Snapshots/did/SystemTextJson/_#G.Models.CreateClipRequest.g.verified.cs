//HintName: G.Models.CreateClipRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipRequest
    {
        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// Default Value: jack-Pt27VkP3hW<br/>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateClipRequestScriptVariant1, global::G.CreateClipRequestScriptVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateClipRequestScriptVariant1, global::G.CreateClipRequestScriptVariant2> Script { get; set; }

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.CreateClipRequestConfig? Config { get; set; }

        /// <summary>
        /// Advanced presenter configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_config")]
        public global::G.CreateClipRequestPresenterConfig? PresenterConfig { get; set; }

        /// <summary>
        /// Background color of the clip result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.CreateClipRequestBackground? Background { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </summary>
        /// <example>https://path.to.directory/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipRequest(
            global::G.AnyOf<global::G.CreateClipRequestScriptVariant1, global::G.CreateClipRequestScriptVariant2> script,
            string? presenterId,
            string? driverId,
            global::G.CreateClipRequestConfig? config,
            global::G.CreateClipRequestPresenterConfig? presenterConfig,
            global::G.CreateClipRequestBackground? background,
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
        /// Initializes a new instance of the <see cref="CreateClipRequest" /> class.
        /// </summary>
        public CreateClipRequest()
        {
        }
    }
}