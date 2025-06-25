//HintName: G.Models.WidgetConfigResponseModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetConfigResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedVariantJsonConverter))]
        public global::G.EmbedVariant? Variant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WidgetPlacementJsonConverter))]
        public global::G.WidgetPlacement? Placement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expandable")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WidgetExpandableJsonConverter))]
        public global::G.WidgetExpandable? Expandable { get; set; }

        /// <summary>
        /// The avatar of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>))]
        public global::G.AnyOf<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WidgetFeedbackModeJsonConverter))]
        public global::G.WidgetFeedbackMode? FeedbackMode { get; set; }

        /// <summary>
        /// The background color of the widget<br/>
        /// Default Value: #ffffff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// The text color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// The button color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_color")]
        public string? BtnColor { get; set; }

        /// <summary>
        /// The button text color of the widget<br/>
        /// Default Value: #ffffff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_text_color")]
        public string? BtnTextColor { get; set; }

        /// <summary>
        /// The border color of the widget<br/>
        /// Default Value: #e1e1e1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border_color")]
        public string? BorderColor { get; set; }

        /// <summary>
        /// The focus color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus_color")]
        public string? FocusColor { get; set; }

        /// <summary>
        /// The border radius of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border_radius")]
        public int? BorderRadius { get; set; }

        /// <summary>
        /// The button radius of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_radius")]
        public int? BtnRadius { get; set; }

        /// <summary>
        /// The action text of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_text")]
        public string? ActionText { get; set; }

        /// <summary>
        /// The start call text of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call_text")]
        public string? StartCallText { get; set; }

        /// <summary>
        /// The end call text of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_text")]
        public string? EndCallText { get; set; }

        /// <summary>
        /// The expand text of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_text")]
        public string? ExpandText { get; set; }

        /// <summary>
        /// The text to display when the agent is listening
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listening_text")]
        public string? ListeningText { get; set; }

        /// <summary>
        /// The text to display when the agent is speaking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_text")]
        public string? SpeakingText { get; set; }

        /// <summary>
        /// The text to display when sharing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable_page_text")]
        public string? ShareablePageText { get; set; }

        /// <summary>
        /// Whether to show terms and conditions on the shareable page<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable_page_show_terms")]
        public bool? ShareablePageShowTerms { get; set; }

        /// <summary>
        /// The text to display for terms and conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_text")]
        public string? TermsText { get; set; }

        /// <summary>
        /// The HTML to display for terms and conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_html")]
        public string? TermsHtml { get; set; }

        /// <summary>
        /// The key to display for terms and conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_key")]
        public string? TermsKey { get; set; }

        /// <summary>
        /// Whether to show the avatar when the widget is collapsed<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_avatar_when_collapsed")]
        public bool? ShowAvatarWhenCollapsed { get; set; }

        /// <summary>
        /// Whether to disable the banner<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_banner")]
        public bool? DisableBanner { get; set; }

        /// <summary>
        /// The override link for the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_link")]
        public string? OverrideLink { get; set; }

        /// <summary>
        /// Whether to enable mic muting<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mic_muting_enabled")]
        public bool? MicMutingEnabled { get; set; }

        /// <summary>
        /// Whether the widget should show the conversation transcript as it goes on<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_enabled")]
        public bool? TranscriptEnabled { get; set; }

        /// <summary>
        /// Whether the user should be able to send text messages<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_input_enabled")]
        public bool? TextInputEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        public global::G.WidgetStyles? Styles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_language_overrides")]
        public global::System.Collections.Generic.IList<string>? SupportedLanguageOverrides { get; set; }

        /// <summary>
        /// Language presets for the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.WidgetLanguagePresetResponse>? LanguagePresets { get; set; }

        /// <summary>
        /// Whether the agent uses text-only mode<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// Whether the agent can be switched to text-only mode<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_text_only")]
        public bool? SupportsTextOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        /// <param name="variant"></param>
        /// <param name="placement"></param>
        /// <param name="expandable"></param>
        /// <param name="avatar">
        /// The avatar of the widget
        /// </param>
        /// <param name="feedbackMode"></param>
        /// <param name="bgColor">
        /// The background color of the widget<br/>
        /// Default Value: #ffffff
        /// </param>
        /// <param name="textColor">
        /// The text color of the widget<br/>
        /// Default Value: #000000
        /// </param>
        /// <param name="btnColor">
        /// The button color of the widget<br/>
        /// Default Value: #000000
        /// </param>
        /// <param name="btnTextColor">
        /// The button text color of the widget<br/>
        /// Default Value: #ffffff
        /// </param>
        /// <param name="borderColor">
        /// The border color of the widget<br/>
        /// Default Value: #e1e1e1
        /// </param>
        /// <param name="focusColor">
        /// The focus color of the widget<br/>
        /// Default Value: #000000
        /// </param>
        /// <param name="borderRadius">
        /// The border radius of the widget
        /// </param>
        /// <param name="btnRadius">
        /// The button radius of the widget
        /// </param>
        /// <param name="actionText">
        /// The action text of the widget
        /// </param>
        /// <param name="startCallText">
        /// The start call text of the widget
        /// </param>
        /// <param name="endCallText">
        /// The end call text of the widget
        /// </param>
        /// <param name="expandText">
        /// The expand text of the widget
        /// </param>
        /// <param name="listeningText">
        /// The text to display when the agent is listening
        /// </param>
        /// <param name="speakingText">
        /// The text to display when the agent is speaking
        /// </param>
        /// <param name="shareablePageText">
        /// The text to display when sharing
        /// </param>
        /// <param name="shareablePageShowTerms">
        /// Whether to show terms and conditions on the shareable page<br/>
        /// Default Value: true
        /// </param>
        /// <param name="termsText">
        /// The text to display for terms and conditions
        /// </param>
        /// <param name="termsHtml">
        /// The HTML to display for terms and conditions
        /// </param>
        /// <param name="termsKey">
        /// The key to display for terms and conditions
        /// </param>
        /// <param name="showAvatarWhenCollapsed">
        /// Whether to show the avatar when the widget is collapsed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableBanner">
        /// Whether to disable the banner<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrideLink">
        /// The override link for the widget
        /// </param>
        /// <param name="micMutingEnabled">
        /// Whether to enable mic muting<br/>
        /// Default Value: false
        /// </param>
        /// <param name="transcriptEnabled">
        /// Whether the widget should show the conversation transcript as it goes on<br/>
        /// Default Value: false
        /// </param>
        /// <param name="textInputEnabled">
        /// Whether the user should be able to send text messages<br/>
        /// Default Value: true
        /// </param>
        /// <param name="textContents"></param>
        /// <param name="styles"></param>
        /// <param name="language"></param>
        /// <param name="supportedLanguageOverrides"></param>
        /// <param name="languagePresets">
        /// Language presets for the widget
        /// </param>
        /// <param name="textOnly">
        /// Whether the agent uses text-only mode<br/>
        /// Default Value: false
        /// </param>
        /// <param name="supportsTextOnly">
        /// Whether the agent can be switched to text-only mode<br/>
        /// Default Value: false
        /// </param>
        /// <param name="firstMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetConfigResponseModel(
            string language,
            global::G.EmbedVariant? variant,
            global::G.WidgetPlacement? placement,
            global::G.WidgetExpandable? expandable,
            global::G.AnyOf<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>? avatar,
            global::G.WidgetFeedbackMode? feedbackMode,
            string? bgColor,
            string? textColor,
            string? btnColor,
            string? btnTextColor,
            string? borderColor,
            string? focusColor,
            int? borderRadius,
            int? btnRadius,
            string? actionText,
            string? startCallText,
            string? endCallText,
            string? expandText,
            string? listeningText,
            string? speakingText,
            string? shareablePageText,
            bool? shareablePageShowTerms,
            string? termsText,
            string? termsHtml,
            string? termsKey,
            bool? showAvatarWhenCollapsed,
            bool? disableBanner,
            string? overrideLink,
            bool? micMutingEnabled,
            bool? transcriptEnabled,
            bool? textInputEnabled,
            global::G.WidgetTextContents? textContents,
            global::G.WidgetStyles? styles,
            global::System.Collections.Generic.IList<string>? supportedLanguageOverrides,
            global::System.Collections.Generic.Dictionary<string, global::G.WidgetLanguagePresetResponse>? languagePresets,
            bool? textOnly,
            bool? supportsTextOnly,
            string? firstMessage)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Variant = variant;
            this.Placement = placement;
            this.Expandable = expandable;
            this.Avatar = avatar;
            this.FeedbackMode = feedbackMode;
            this.BgColor = bgColor;
            this.TextColor = textColor;
            this.BtnColor = btnColor;
            this.BtnTextColor = btnTextColor;
            this.BorderColor = borderColor;
            this.FocusColor = focusColor;
            this.BorderRadius = borderRadius;
            this.BtnRadius = btnRadius;
            this.ActionText = actionText;
            this.StartCallText = startCallText;
            this.EndCallText = endCallText;
            this.ExpandText = expandText;
            this.ListeningText = listeningText;
            this.SpeakingText = speakingText;
            this.ShareablePageText = shareablePageText;
            this.ShareablePageShowTerms = shareablePageShowTerms;
            this.TermsText = termsText;
            this.TermsHtml = termsHtml;
            this.TermsKey = termsKey;
            this.ShowAvatarWhenCollapsed = showAvatarWhenCollapsed;
            this.DisableBanner = disableBanner;
            this.OverrideLink = overrideLink;
            this.MicMutingEnabled = micMutingEnabled;
            this.TranscriptEnabled = transcriptEnabled;
            this.TextInputEnabled = textInputEnabled;
            this.TextContents = textContents;
            this.Styles = styles;
            this.SupportedLanguageOverrides = supportedLanguageOverrides;
            this.LanguagePresets = languagePresets;
            this.TextOnly = textOnly;
            this.SupportsTextOnly = supportsTextOnly;
            this.FirstMessage = firstMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        public WidgetConfigResponseModel()
        {
        }
    }
}