//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParamsBrowserSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext? Context { get; set; }

        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewport")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport? Viewport { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsJsonConverter))]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? Os { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Resource size of the browser.<br/>
        /// Default Value: small
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeJsonConverter))]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? Size { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable native select polyfill. This gives support a break-glass option to disable the polyfill.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enableNativeSelectPolyfill")]
        public bool? EnableNativeSelectPolyfill { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable PDF viewer. This gives support a break-glass option to enable the viewer when users want to view PDFs in-browser.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enablePdfViewer")]
        public bool? EnablePdfViewer { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable or disable headful mode. Defaults to `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headful")]
        public bool? Headful { get; set; }

        /// <summary>
        /// [NOT IN DOCS] List of pre-installed extension names and custom extension ids to enable on the browser<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extensions")]
        public global::System.Collections.Generic.IList<global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? Extensions { get; set; }

        /// <summary>
        /// An optional list of allowed domains for the session. If provided, navigation will be restricted to these domains.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowedDomains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettings" /> class.
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
        /// <param name="size">
        /// [NOT IN DOCS] Resource size of the browser.<br/>
        /// Default Value: small
        /// </param>
        /// <param name="enableNativeSelectPolyfill">
        /// [NOT IN DOCS] Enable native select polyfill. This gives support a break-glass option to disable the polyfill.
        /// </param>
        /// <param name="enablePdfViewer">
        /// [NOT IN DOCS] Enable PDF viewer. This gives support a break-glass option to enable the viewer when users want to view PDFs in-browser.
        /// </param>
        /// <param name="headful">
        /// [NOT IN DOCS] Enable or disable headful mode. Defaults to `false`.
        /// </param>
        /// <param name="extensions">
        /// [NOT IN DOCS] List of pre-installed extension names and custom extension ids to enable on the browser<br/>
        /// Default Value: []
        /// </param>
        /// <param name="allowedDomains">
        /// An optional list of allowed domains for the session. If provided, navigation will be restricted to these domains.<br/>
        /// Default Value: []
        /// </param>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettings(
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext? context,
            string? extensionId,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport? viewport,
            bool? blockAds,
            bool? solveCaptchas,
            bool? recordSession,
            bool? logSession,
            bool? advancedStealth,
            string? captchaImageSelector,
            string? captchaInputSelector,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? os,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? size,
            bool? enableNativeSelectPolyfill,
            bool? enablePdfViewer,
            bool? headful,
            global::System.Collections.Generic.IList<global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? extensions,
            global::System.Collections.Generic.IList<string>? allowedDomains)
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
            this.Size = size;
            this.EnableNativeSelectPolyfill = enableNativeSelectPolyfill;
            this.EnablePdfViewer = enablePdfViewer;
            this.Headful = headful;
            this.Extensions = extensions;
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettings" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettings()
        {
        }
    }
}