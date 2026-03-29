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
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext? Context { get; set; }

        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewport")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport? Viewport { get; set; }

        /// <summary>
        /// Enable or disable ad blocking in the browser. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockAds")]
        public bool? BlockAds { get; set; }

        /// <summary>
        /// Enable or disable captcha solving in the browser. Defaults to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("solveCaptchas")]
        public bool? SolveCaptchas { get; set; }

        /// <summary>
        /// Enable or disable session recording. Defaults to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordSession")]
        public bool? RecordSession { get; set; }

        /// <summary>
        /// Enable or disable session logging. Defaults to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logSession")]
        public bool? LogSession { get; set; }

        /// <summary>
        /// Advanced Browser Stealth Mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advancedStealth")]
        public bool? AdvancedStealth { get; set; }

        /// <summary>
        /// Custom selector for captcha image. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captchaImageSelector")]
        public string? CaptchaImageSelector { get; set; }

        /// <summary>
        /// Custom selector for captcha input. See [Custom Captcha Solving](/features/stealth-mode#custom-captcha-solving)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captchaInputSelector")]
        public string? CaptchaInputSelector { get; set; }

        /// <summary>
        /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsJsonConverter))]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? Os { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Resource size of the browser.<br/>
        /// Default Value: small
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeJsonConverter))]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? Size { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable native select polyfill. This gives support a break-glass option to disable the polyfill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableNativeSelectPolyfill")]
        public bool? EnableNativeSelectPolyfill { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable PDF viewer. This gives support a break-glass option to enable the viewer when users want to view PDFs in-browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePdfViewer")]
        public bool? EnablePdfViewer { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Enable or disable headful mode. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headful")]
        public bool? Headful { get; set; }

        /// <summary>
        /// [NOT IN DOCS] List of pre-installed extension names and custom extension ids to enable on the browser<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? Extensions { get; set; }

        /// <summary>
        /// An optional list of allowed domains for the session. If provided, navigation will be restricted to these domains.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedDomains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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