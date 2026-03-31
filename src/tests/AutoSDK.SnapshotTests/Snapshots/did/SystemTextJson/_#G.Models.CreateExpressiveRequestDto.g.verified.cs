//HintName: G.Models.CreateExpressiveRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flattens intersection types into a single object type.<br/>
    /// This is useful for improving validation error messages and type display.
    /// </summary>
    public sealed partial class CreateExpressiveRequestDto
    {
        /// <summary>
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </summary>
        /// <example>my_expressive_video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </summary>
        /// <example>public_dan@abcefg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarId { get; set; }

        /// <summary>
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </summary>
        /// <example>snt_IIjpTS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_id")]
        public string? SentimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.CreateExpressiveRequestDtoConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateExpressiveRequestDtoBackgroundVariant1, global::G.CreateExpressiveRequestDtoBackgroundVariant2>))]
        public global::G.AnyOf<global::G.CreateExpressiveRequestDtoBackgroundVariant1, global::G.CreateExpressiveRequestDtoBackgroundVariant2>? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </summary>
        /// <example>https://example.com/result.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateExpressiveRequestDtoScriptVariant1, global::G.CreateExpressiveRequestDtoScriptVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateExpressiveRequestDtoScriptVariant1, global::G.CreateExpressiveRequestDtoScriptVariant2> Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDto" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressiveRequestDto(
            string avatarId,
            global::G.AnyOf<global::G.CreateExpressiveRequestDtoScriptVariant1, global::G.CreateExpressiveRequestDtoScriptVariant2> script,
            string? name,
            string? sentimentId,
            global::G.CreateExpressiveRequestDtoConfig? config,
            global::G.AnyOf<global::G.CreateExpressiveRequestDtoBackgroundVariant1, global::G.CreateExpressiveRequestDtoBackgroundVariant2>? background,
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
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDto" /> class.
        /// </summary>
        public CreateExpressiveRequestDto()
        {
        }
    }
}