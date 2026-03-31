//HintName: G.Models.CreateSceneRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSceneRequestDto
    {
        /// <summary>
        /// The avatar that will be used to create the scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateSceneRequestDtoScriptText, global::G.CreateSceneRequestDtoScriptAudio>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateSceneRequestDtoScriptText, global::G.CreateSceneRequestDtoScriptAudio> Script { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including scene details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the scene
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the scene, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.CreateSceneRequestDtoConfig? Config { get; set; }

        /// <summary>
        /// Background color of the scene result, can only be used for avatars with green screen background
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.CreateSceneRequestDtoBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSceneRequestDto" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSceneRequestDto(
            string avatarId,
            global::G.AnyOf<global::G.CreateSceneRequestDtoScriptText, global::G.CreateSceneRequestDtoScriptAudio> script,
            string? webhook,
            string? userData,
            string? name,
            string? resultUrl,
            global::G.CreateSceneRequestDtoConfig? config,
            global::G.CreateSceneRequestDtoBackground? background)
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
        /// Initializes a new instance of the <see cref="CreateSceneRequestDto" /> class.
        /// </summary>
        public CreateSceneRequestDto()
        {
        }
    }
}