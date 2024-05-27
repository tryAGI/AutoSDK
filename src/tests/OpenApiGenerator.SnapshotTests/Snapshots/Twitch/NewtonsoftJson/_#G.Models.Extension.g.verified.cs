//HintName: G.Models.Extension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Extension
    {
        /// <summary>
        /// The name of the user or organization that owns the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthorName { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension has features that use Bits. Is **true** if the extension has features that use Bits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool BitsEnabled { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether a user can install the extension on their channel. Is **true** if a user can install the extension.  
        ///   
        /// Typically, this is set to **false** if the extension is currently in testing mode and requires users to be allowlisted (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Access**).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_install", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanInstall { get; set; } = default!;

        /// <summary>
        /// The location of where the extension’s configuration is stored. Possible values are:  
        ///   
        /// * hosted — The Extensions Configuration Service hosts the configuration.
        /// * custom — The Extension Backend Service (EBS) hosts the configuration.
        /// * none — The extension doesn't require configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_location", Required = global::Newtonsoft.Json.Required.Always)]
        public ExtensionConfigurationLocation ConfigurationLocation { get; set; } = default!;

        /// <summary>
        /// A longer description of the extension. It appears on the details page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// A URL to the extension’s Terms of Service.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eula_tos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EulaTosUrl { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension can communicate with the installed channel’s chat. Is **true** if the extension can communicate with the channel’s chat room.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_chat_support", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasChatSupport { get; set; } = default!;

        /// <summary>
        /// A URL to the default icon that’s displayed in the Extensions directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IconUrl { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public ExtensionIconUrls IconUrls { get; set; } = default!;

        /// <summary>
        /// The extension’s ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The extension’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A URL to the extension’s privacy policy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy_policy_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrivacyPolicyUrl { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension wants to explicitly ask viewers to link their Twitch identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_identity_link", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequestIdentityLink { get; set; } = default!;

        /// <summary>
        /// A list of URLs to screenshots that are shown in the Extensions marketplace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("screenshot_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ScreenshotUrls { get; set; } = default!;

        /// <summary>
        /// The extension’s state. Possible values are:  
        ///   
        /// * Approved
        /// * AssetsUploaded
        /// * Deleted
        /// * Deprecated
        /// * InReview
        /// * InTest
        /// * PendingAction
        /// * Rejected
        /// * Released
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public ExtensionState State { get; set; } = default!;

        /// <summary>
        /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  
        ///   
        /// * none — The extension can't view the user’s subscription level.
        /// * optional — The extension can view the user’s subscription level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_support_level", Required = global::Newtonsoft.Json.Required.Always)]
        public ExtensionSubscriptionsSupportLevel SubscriptionsSupportLevel { get; set; } = default!;

        /// <summary>
        /// A short description of the extension that streamers see when hovering over the discovery splash screen in the Extensions manager.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// The email address that users use to get support for the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("support_email", Required = global::Newtonsoft.Json.Required.Always)]
        public string SupportEmail { get; set; } = default!;

        /// <summary>
        /// The extension’s version number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// A brief description displayed on the channel to explain how the extension works.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewer_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerSummary { get; set; } = default!;

        /// <summary>
        /// Describes all views-related information such as how the extension is displayed on mobile devices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("views", Required = global::Newtonsoft.Json.Required.Always)]
        public ExtensionViews Views { get; set; } = default!;

        /// <summary>
        /// Allowlisted configuration URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowlisted_config_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowlistedConfigUrls { get; set; } = default!;

        /// <summary>
        /// Allowlisted panel URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowlisted_panel_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowlistedPanelUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}