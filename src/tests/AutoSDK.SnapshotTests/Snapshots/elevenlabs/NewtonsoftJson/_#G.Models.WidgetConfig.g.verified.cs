//HintName: G.Models.WidgetConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variant")]
        public global::G.EmbedVariant? Variant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expandable")]
        public global::G.WidgetExpandable? Expandable { get; set; }

        /// <summary>
        /// The avatar of the widget
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public global::G.AnyOf<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_mode")]
        public global::G.WidgetFeedbackMode? FeedbackMode { get; set; }

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
        /// Whether to enable mic muting<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mic_muting_enabled")]
        public bool? MicMutingEnabled { get; set; }

        /// <summary>
        /// Whether to show the language selector<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_selector")]
        public bool? LanguageSelector { get; set; }

        /// <summary>
        /// The custom avatar path
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_avatar_path")]
        public string? CustomAvatarPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfig" /> class.
        /// </summary>
        /// <param name="variant"></param>
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
        /// <param name="micMutingEnabled">
        /// Whether to enable mic muting<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageSelector">
        /// Whether to show the language selector<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customAvatarPath">
        /// The custom avatar path
        /// </param>
        public WidgetConfig(
            global::G.EmbedVariant? variant,
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
            bool? micMutingEnabled,
            bool? languageSelector,
            string? customAvatarPath)
        {
            this.Variant = variant;
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
            this.MicMutingEnabled = micMutingEnabled;
            this.LanguageSelector = languageSelector;
            this.CustomAvatarPath = customAvatarPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfig" /> class.
        /// </summary>
        public WidgetConfig()
        {
        }
    }
}