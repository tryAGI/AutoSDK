//HintName: G.Models.SessionsCreateRequestBrowserSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsCreateRequestBrowserSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::G.SessionsCreateRequestBrowserSettingsContext? Context { get; set; }

        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewport")]
        public global::G.SessionsCreateRequestBrowserSettingsViewport? Viewport { get; set; }

        /// <summary>
        /// Enable or disable ad blocking in the browser. Defaults to `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blockAds")]
        public bool? BlockAds { get; set; }

        /// <summary>
        /// Enable or disable captcha solving in the browser. Defaults to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("solveCaptchas")]
        public bool? SolveCaptchas { get; set; }

        /// <summary>
        /// Enable or disable session recording. Defaults to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordSession")]
        public bool? RecordSession { get; set; }

        /// <summary>
        /// Enable or disable session logging. Defaults to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logSession")]
        public bool? LogSession { get; set; }

        /// <summary>
        /// Advanced Browser Stealth Mode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advancedStealth")]
        public bool? AdvancedStealth { get; set; }

        /// <summary>
        /// Custom selector for captcha image. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captchaImageSelector")]
        public string? CaptchaImageSelector { get; set; }

        /// <summary>
        /// Custom selector for captcha input. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captchaInputSelector")]
        public string? CaptchaInputSelector { get; set; }

        /// <summary>
        /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("os")]
        public global::G.SessionsCreateRequestBrowserSettingsOs? Os { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettings" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="extensionId">
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </param>
        /// <param name="viewport"></param>
        /// <param name="blockAds">
        /// Enable or disable ad blocking in the browser. Defaults to `false`.
        /// </param>
        /// <param name="solveCaptchas">
        /// Enable or disable captcha solving in the browser. Defaults to `true`.
        /// </param>
        /// <param name="recordSession">
        /// Enable or disable session recording. Defaults to `true`.
        /// </param>
        /// <param name="logSession">
        /// Enable or disable session logging. Defaults to `true`.
        /// </param>
        /// <param name="advancedStealth">
        /// Advanced Browser Stealth Mode
        /// </param>
        /// <param name="captchaImageSelector">
        /// Custom selector for captcha image. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </param>
        /// <param name="captchaInputSelector">
        /// Custom selector for captcha input. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </param>
        /// <param name="os">
        /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
        /// </param>
        public SessionsCreateRequestBrowserSettings(
            global::G.SessionsCreateRequestBrowserSettingsContext? context,
            string? extensionId,
            global::G.SessionsCreateRequestBrowserSettingsViewport? viewport,
            bool? blockAds,
            bool? solveCaptchas,
            bool? recordSession,
            bool? logSession,
            bool? advancedStealth,
            string? captchaImageSelector,
            string? captchaInputSelector,
            global::G.SessionsCreateRequestBrowserSettingsOs? os)
        {
            this.Context = context;
            this.ExtensionId = extensionId;
            this.Viewport = viewport;
            this.BlockAds = blockAds;
            this.SolveCaptchas = solveCaptchas;
            this.RecordSession = recordSession;
            this.LogSession = logSession;
            this.AdvancedStealth = advancedStealth;
            this.CaptchaImageSelector = captchaImageSelector;
            this.CaptchaInputSelector = captchaInputSelector;
            this.Os = os;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettings" /> class.
        /// </summary>
        public SessionsCreateRequestBrowserSettings()
        {
        }
    }
}