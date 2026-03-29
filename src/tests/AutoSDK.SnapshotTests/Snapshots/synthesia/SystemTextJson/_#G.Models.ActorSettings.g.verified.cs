//HintName: G.Models.ActorSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorSettings
    {
        /// <summary>
        /// HEX color code (e.g. #F2F7FF) for the background of circular style avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public object? BackgroundColor { get; set; }

        /// <summary>
        /// At the moment `verticalAlign` field is not exposed via API and is fixed to `bottom`, however together with `horizontalAlign` they define a reference point from where we scale the rectangular style avatar. For example, `horizontal alignment: left`, would mean that avatar is called from the bottom-left corner towards the top-right corner.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontalAlign")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActorSettingsHorizontalAlignJsonConverter))]
        public global::G.ActorSettingsHorizontalAlign? HorizontalAlign { get; set; }

        /// <summary>
        /// The scale of the avatar.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// `rectangular` style corresponds to the "Full body" avatar style in STUDIO. `circular style corresponds to the "Circle" avatar style in STUDIO. The position of circular avatar is fixed to the center of the video both vertically and horizontally, and can't be changed. With scale 1.0, circular avatar will cover total height of the video. Use circular style, if you need to make a round cutout of the avatar to integrate into e.g. screen recording app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActorSettingsStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActorSettingsStyle Style { get; set; }

        /// <summary>
        /// If a voice is not provided, defaults to our recommended voice for the selected avatar. See the complete list of voices.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::System.Guid? Voice { get; set; }

        /// <summary>
        /// When the seamless option is enabled, a video of the avatar will be generated in a way that first and last frames match, so videos can be concatenated seamlessly. Use seamless option, if you need to play videos back to back seamlessly e.g. in a video chatbot app. Limitations: - Only work with anna_costume1_cameraA and mia_costume1_cameraA actors. - Only work with static (image) backgrounds. - Videos will have noticeably lower quality. Though, this might not matter, depending on your use case.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seamless")]
        public bool? Seamless { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorSettings" /> class.
        /// </summary>
        /// <param name="style">
        /// `rectangular` style corresponds to the "Full body" avatar style in STUDIO. `circular style corresponds to the "Circle" avatar style in STUDIO. The position of circular avatar is fixed to the center of the video both vertically and horizontally, and can't be changed. With scale 1.0, circular avatar will cover total height of the video. Use circular style, if you need to make a round cutout of the avatar to integrate into e.g. screen recording app
        /// </param>
        /// <param name="backgroundColor">
        /// HEX color code (e.g. #F2F7FF) for the background of circular style avatar.
        /// </param>
        /// <param name="horizontalAlign">
        /// At the moment `verticalAlign` field is not exposed via API and is fixed to `bottom`, however together with `horizontalAlign` they define a reference point from where we scale the rectangular style avatar. For example, `horizontal alignment: left`, would mean that avatar is called from the bottom-left corner towards the top-right corner.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scale">
        /// The scale of the avatar.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voice">
        /// If a voice is not provided, defaults to our recommended voice for the selected avatar. See the complete list of voices.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="seamless">
        /// When the seamless option is enabled, a video of the avatar will be generated in a way that first and last frames match, so videos can be concatenated seamlessly. Use seamless option, if you need to play videos back to back seamlessly e.g. in a video chatbot app. Limitations: - Only work with anna_costume1_cameraA and mia_costume1_cameraA actors. - Only work with static (image) backgrounds. - Videos will have noticeably lower quality. Though, this might not matter, depending on your use case.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorSettings(
            global::G.ActorSettingsStyle style,
            object? backgroundColor,
            global::G.ActorSettingsHorizontalAlign? horizontalAlign,
            double? scale,
            global::System.Guid? voice,
            bool? seamless)
        {
            this.BackgroundColor = backgroundColor;
            this.HorizontalAlign = horizontalAlign;
            this.Scale = scale;
            this.Style = style;
            this.Voice = voice;
            this.Seamless = seamless;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorSettings" /> class.
        /// </summary>
        public ActorSettings()
        {
        }
    }
}