//HintName: G.Models.WidgetConfigResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"first_message":"Hello! How can I help you today?","language":"en","language_presets":{},"supported_language_overrides":["es","fr"],"supports_text_only":true,"text_only":false,"use_rtc":false}
    /// </summary>
    public sealed partial class WidgetConfigResponseModel
    {
        /// <summary>
        /// The variant of the widget<br/>
        /// Default Value: full
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variant")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbedVariantJsonConverter))]
        public global::G.EmbedVariant? Variant { get; set; }

        /// <summary>
        /// The placement of the widget on the screen<br/>
        /// Default Value: bottom-right
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("placement")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WidgetPlacementJsonConverter))]
        public global::G.WidgetPlacement? Placement { get; set; }

        /// <summary>
        /// Whether the widget is expandable<br/>
        /// Default Value: never
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expandable")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WidgetExpandableJsonConverter))]
        public global::G.WidgetExpandable? Expandable { get; set; }

        /// <summary>
        /// The avatar of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public global::G.AnyOf<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>? Avatar { get; set; }

        /// <summary>
        /// The feedback mode of the widget<br/>
        /// Default Value: none
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WidgetFeedbackModeJsonConverter))]
        public global::G.WidgetFeedbackMode? FeedbackMode { get; set; }

        /// <summary>
        /// Configuration for feedback collected at the end of the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_feedback")]
        public global::G.WidgetEndFeedbackConfig? EndFeedback { get; set; }

        /// <summary>
        /// The background color of the widget<br/>
        /// Default Value: #ffffff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// The text color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// The button color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btn_color")]
        public string? BtnColor { get; set; }

        /// <summary>
        /// The button text color of the widget<br/>
        /// Default Value: #ffffff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btn_text_color")]
        public string? BtnTextColor { get; set; }

        /// <summary>
        /// The border color of the widget<br/>
        /// Default Value: #e1e1e1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("border_color")]
        public string? BorderColor { get; set; }

        /// <summary>
        /// The focus color of the widget<br/>
        /// Default Value: #000000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("focus_color")]
        public string? FocusColor { get; set; }

        /// <summary>
        /// The border radius of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("border_radius")]
        public int? BorderRadius { get; set; }

        /// <summary>
        /// The button radius of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btn_radius")]
        public int? BtnRadius { get; set; }

        /// <summary>
        /// The action text of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action_text")]
        public string? ActionText { get; set; }

        /// <summary>
        /// The start call text of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_call_text")]
        public string? StartCallText { get; set; }

        /// <summary>
        /// The end call text of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_call_text")]
        public string? EndCallText { get; set; }

        /// <summary>
        /// The expand text of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expand_text")]
        public string? ExpandText { get; set; }

        /// <summary>
        /// The text to display when the agent is listening
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("listening_text")]
        public string? ListeningText { get; set; }

        /// <summary>
        /// The text to display when the agent is speaking
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaking_text")]
        public string? SpeakingText { get; set; }

        /// <summary>
        /// The text to display when sharing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shareable_page_text")]
        public string? ShareablePageText { get; set; }

        /// <summary>
        /// Whether to show terms and conditions on the shareable page<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shareable_page_show_terms")]
        public bool? ShareablePageShowTerms { get; set; }

        /// <summary>
        /// The text to display for terms and conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_text")]
        public string? TermsText { get; set; }

        /// <summary>
        /// The HTML to display for terms and conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_html")]
        public string? TermsHtml { get; set; }

        /// <summary>
        /// The key to display for terms and conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_key")]
        public string? TermsKey { get; set; }

        /// <summary>
        /// Whether to show the avatar when the widget is collapsed<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_avatar_when_collapsed")]
        public bool? ShowAvatarWhenCollapsed { get; set; }

        /// <summary>
        /// Whether to disable the banner<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_banner")]
        public bool? DisableBanner { get; set; }

        /// <summary>
        /// The override link for the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_link")]
        public string? OverrideLink { get; set; }

        /// <summary>
        /// List of allowed hostnames for clickable markdown links. Use { hostname: '*' } to allow any domain. Empty means no links are allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown_link_allowed_hosts")]
        public global::System.Collections.Generic.IList<global::G.AllowlistItem>? MarkdownLinkAllowedHosts { get; set; }

        /// <summary>
        /// Whether to automatically include www. variants of allowed hosts<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown_link_include_www")]
        public bool? MarkdownLinkIncludeWww { get; set; }

        /// <summary>
        /// Whether to allow http:// in addition to https:// for allowed hosts<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown_link_allow_http")]
        public bool? MarkdownLinkAllowHttp { get; set; }

        /// <summary>
        /// Whether to enable mic muting<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mic_muting_enabled")]
        public bool? MicMutingEnabled { get; set; }

        /// <summary>
        /// Whether the widget should show the conversation transcript as it goes on<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_enabled")]
        public bool? TranscriptEnabled { get; set; }

        /// <summary>
        /// Whether the user should be able to send text messages<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_input_enabled")]
        public bool? TextInputEnabled { get; set; }

        /// <summary>
        /// Whether to enable the conversation mode toggle in the widget<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_mode_toggle_enabled")]
        public bool? ConversationModeToggleEnabled { get; set; }

        /// <summary>
        /// Whether the widget should be expanded by default<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_expanded")]
        public bool? DefaultExpanded { get; set; }

        /// <summary>
        /// Whether the widget should always be expanded<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("always_expanded")]
        public bool? AlwaysExpanded { get; set; }

        /// <summary>
        /// Whether the widget can be dismissed by the user<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissible")]
        public bool? Dismissible { get; set; }

        /// <summary>
        /// Whether to show agent working/done/error status during tool use<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_agent_status")]
        public bool? ShowAgentStatus { get; set; }

        /// <summary>
        /// Whether to show the conversation ID after disconnection.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_conversation_id")]
        public bool? ShowConversationId { get; set; }

        /// <summary>
        /// Whether to strip audio markup from messages.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strip_audio_tags")]
        public bool? StripAudioTags { get; set; }

        /// <summary>
        /// Theme for code block syntax highlighting. Defaults to auto-detection by the widget when not set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("syntax_highlight_theme")]
        public global::G.WidgetConfigResponseModelSyntaxHighlightTheme2? SyntaxHighlightTheme { get; set; }

        /// <summary>
        /// Text contents of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// Styles for the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("styles")]
        public global::G.WidgetStyles? Styles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_language_overrides")]
        public global::System.Collections.Generic.IList<string>? SupportedLanguageOverrides { get; set; }

        /// <summary>
        /// Language presets for the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.WidgetLanguagePresetResponse>? LanguagePresets { get; set; }

        /// <summary>
        /// Whether the agent uses text-only mode<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// Whether the agent can be switched to text-only mode<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_text_only")]
        public bool? SupportsTextOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Whether to use WebRTC for conversation connections
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_rtc")]
        public bool? UseRtc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="variant">
        /// The variant of the widget<br/>
        /// Default Value: full
        /// </param>
        /// <param name="placement">
        /// The placement of the widget on the screen<br/>
        /// Default Value: bottom-right
        /// </param>
        /// <param name="expandable">
        /// Whether the widget is expandable<br/>
        /// Default Value: never
        /// </param>
        /// <param name="avatar">
        /// The avatar of the widget
        /// </param>
        /// <param name="feedbackMode">
        /// The feedback mode of the widget<br/>
        /// Default Value: none
        /// </param>
        /// <param name="endFeedback">
        /// Configuration for feedback collected at the end of the conversation
        /// </param>
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
        /// <param name="markdownLinkAllowedHosts">
        /// List of allowed hostnames for clickable markdown links. Use { hostname: '*' } to allow any domain. Empty means no links are allowed.
        /// </param>
        /// <param name="markdownLinkIncludeWww">
        /// Whether to automatically include www. variants of allowed hosts<br/>
        /// Default Value: true
        /// </param>
        /// <param name="markdownLinkAllowHttp">
        /// Whether to allow http:// in addition to https:// for allowed hosts<br/>
        /// Default Value: true
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
        /// <param name="conversationModeToggleEnabled">
        /// Whether to enable the conversation mode toggle in the widget<br/>
        /// Default Value: false
        /// </param>
        /// <param name="defaultExpanded">
        /// Whether the widget should be expanded by default<br/>
        /// Default Value: false
        /// </param>
        /// <param name="alwaysExpanded">
        /// Whether the widget should always be expanded<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dismissible">
        /// Whether the widget can be dismissed by the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="showAgentStatus">
        /// Whether to show agent working/done/error status during tool use<br/>
        /// Default Value: false
        /// </param>
        /// <param name="showConversationId">
        /// Whether to show the conversation ID after disconnection.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripAudioTags">
        /// Whether to strip audio markup from messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="syntaxHighlightTheme">
        /// Theme for code block syntax highlighting. Defaults to auto-detection by the widget when not set.
        /// </param>
        /// <param name="textContents">
        /// Text contents of the widget
        /// </param>
        /// <param name="styles">
        /// Styles for the widget
        /// </param>
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
        /// <param name="useRtc">
        /// Whether to use WebRTC for conversation connections
        /// </param>
        public WidgetConfigResponseModel(
            string language,
            global::G.EmbedVariant? variant,
            global::G.WidgetPlacement? placement,
            global::G.WidgetExpandable? expandable,
            global::G.AnyOf<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>? avatar,
            global::G.WidgetFeedbackMode? feedbackMode,
            global::G.WidgetEndFeedbackConfig? endFeedback,
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
            global::System.Collections.Generic.IList<global::G.AllowlistItem>? markdownLinkAllowedHosts,
            bool? markdownLinkIncludeWww,
            bool? markdownLinkAllowHttp,
            bool? micMutingEnabled,
            bool? transcriptEnabled,
            bool? textInputEnabled,
            bool? conversationModeToggleEnabled,
            bool? defaultExpanded,
            bool? alwaysExpanded,
            bool? dismissible,
            bool? showAgentStatus,
            bool? showConversationId,
            bool? stripAudioTags,
            global::G.WidgetConfigResponseModelSyntaxHighlightTheme2? syntaxHighlightTheme,
            global::G.WidgetTextContents? textContents,
            global::G.WidgetStyles? styles,
            global::System.Collections.Generic.IList<string>? supportedLanguageOverrides,
            global::System.Collections.Generic.Dictionary<string, global::G.WidgetLanguagePresetResponse>? languagePresets,
            bool? textOnly,
            bool? supportsTextOnly,
            string? firstMessage,
            bool? useRtc)
        {
            this.Variant = variant;
            this.Placement = placement;
            this.Expandable = expandable;
            this.Avatar = avatar;
            this.FeedbackMode = feedbackMode;
            this.EndFeedback = endFeedback;
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
            this.MarkdownLinkAllowedHosts = markdownLinkAllowedHosts;
            this.MarkdownLinkIncludeWww = markdownLinkIncludeWww;
            this.MarkdownLinkAllowHttp = markdownLinkAllowHttp;
            this.MicMutingEnabled = micMutingEnabled;
            this.TranscriptEnabled = transcriptEnabled;
            this.TextInputEnabled = textInputEnabled;
            this.ConversationModeToggleEnabled = conversationModeToggleEnabled;
            this.DefaultExpanded = defaultExpanded;
            this.AlwaysExpanded = alwaysExpanded;
            this.Dismissible = dismissible;
            this.ShowAgentStatus = showAgentStatus;
            this.ShowConversationId = showConversationId;
            this.StripAudioTags = stripAudioTags;
            this.SyntaxHighlightTheme = syntaxHighlightTheme;
            this.TextContents = textContents;
            this.Styles = styles;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.SupportedLanguageOverrides = supportedLanguageOverrides;
            this.LanguagePresets = languagePresets;
            this.TextOnly = textOnly;
            this.SupportsTextOnly = supportsTextOnly;
            this.FirstMessage = firstMessage;
            this.UseRtc = useRtc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        public WidgetConfigResponseModel()
        {
        }
    }
}