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
        [global::System.Text.Json.Serialization.JsonPropertyName("author_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorName { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the extension has features that use Bits. Is **true** if the extension has features that use Bits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BitsEnabled { get; set; }

        /// <summary>
        /// A Boolean value that determines whether a user can install the extension on their channel. Is **true** if a user can install the extension.  <br/>
        ///   <br/>
        /// Typically, this is set to **false** if the extension is currently in testing mode and requires users to be allowlisted (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Access**).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_install")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanInstall { get; set; }

        /// <summary>
        /// The location of where the extension’s configuration is stored. Possible values are:  <br/>
        ///   <br/>
        /// * hosted — The Extensions Configuration Service hosts the configuration.<br/>
        /// * custom — The Extension Backend Service (EBS) hosts the configuration.<br/>
        /// * none — The extension doesn't require configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionConfigurationLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionConfigurationLocation ConfigurationLocation { get; set; }

        /// <summary>
        /// A longer description of the extension. It appears on the details page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A URL to the extension’s Terms of Service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eula_tos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EulaTosUrl { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the extension can communicate with the installed channel’s chat. Is **true** if the extension can communicate with the channel’s chat room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_chat_support")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasChatSupport { get; set; }

        /// <summary>
        /// A URL to the default icon that’s displayed in the Extensions directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionIconUrls IconUrls { get; set; }

        /// <summary>
        /// The extension’s ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The extension’s name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A URL to the extension’s privacy policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_policy_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the extension wants to explicitly ask viewers to link their Twitch identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_identity_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequestIdentityLink { get; set; }

        /// <summary>
        /// A list of URLs to screenshots that are shown in the Extensions marketplace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScreenshotUrls { get; set; }

        /// <summary>
        /// The extension’s state. Possible values are:  <br/>
        ///   <br/>
        /// * Approved<br/>
        /// * AssetsUploaded<br/>
        /// * Deleted<br/>
        /// * Deprecated<br/>
        /// * InReview<br/>
        /// * InTest<br/>
        /// * PendingAction<br/>
        /// * Rejected<br/>
        /// * Released
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionState State { get; set; }

        /// <summary>
        /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  <br/>
        ///   <br/>
        /// * none — The extension can't view the user’s subscription level.<br/>
        /// * optional — The extension can view the user’s subscription level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions_support_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionSubscriptionsSupportLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionSubscriptionsSupportLevel SubscriptionsSupportLevel { get; set; }

        /// <summary>
        /// A short description of the extension that streamers see when hovering over the discovery splash screen in the Extensions manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// The email address that users use to get support for the extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("support_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SupportEmail { get; set; }

        /// <summary>
        /// The extension’s version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// A brief description displayed on the channel to explain how the extension works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewerSummary { get; set; }

        /// <summary>
        /// Describes all views-related information such as how the extension is displayed on mobile devices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionViews Views { get; set; }

        /// <summary>
        /// Allowlisted configuration URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlisted_config_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowlistedConfigUrls { get; set; }

        /// <summary>
        /// Allowlisted panel URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlisted_panel_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowlistedPanelUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Extension" /> class.
        /// </summary>
        /// <param name="authorName">
        /// The name of the user or organization that owns the extension.
        /// </param>
        /// <param name="bitsEnabled">
        /// A Boolean value that determines whether the extension has features that use Bits. Is **true** if the extension has features that use Bits.
        /// </param>
        /// <param name="canInstall">
        /// A Boolean value that determines whether a user can install the extension on their channel. Is **true** if a user can install the extension.  <br/>
        ///   <br/>
        /// Typically, this is set to **false** if the extension is currently in testing mode and requires users to be allowlisted (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Access**).
        /// </param>
        /// <param name="configurationLocation">
        /// The location of where the extension’s configuration is stored. Possible values are:  <br/>
        ///   <br/>
        /// * hosted — The Extensions Configuration Service hosts the configuration.<br/>
        /// * custom — The Extension Backend Service (EBS) hosts the configuration.<br/>
        /// * none — The extension doesn't require configuration.
        /// </param>
        /// <param name="description">
        /// A longer description of the extension. It appears on the details page.
        /// </param>
        /// <param name="eulaTosUrl">
        /// A URL to the extension’s Terms of Service.
        /// </param>
        /// <param name="hasChatSupport">
        /// A Boolean value that determines whether the extension can communicate with the installed channel’s chat. Is **true** if the extension can communicate with the channel’s chat room.
        /// </param>
        /// <param name="iconUrl">
        /// A URL to the default icon that’s displayed in the Extensions directory.
        /// </param>
        /// <param name="iconUrls">
        /// A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.
        /// </param>
        /// <param name="id">
        /// The extension’s ID.
        /// </param>
        /// <param name="name">
        /// The extension’s name.
        /// </param>
        /// <param name="privacyPolicyUrl">
        /// A URL to the extension’s privacy policy.
        /// </param>
        /// <param name="requestIdentityLink">
        /// A Boolean value that determines whether the extension wants to explicitly ask viewers to link their Twitch identity.
        /// </param>
        /// <param name="screenshotUrls">
        /// A list of URLs to screenshots that are shown in the Extensions marketplace.
        /// </param>
        /// <param name="state">
        /// The extension’s state. Possible values are:  <br/>
        ///   <br/>
        /// * Approved<br/>
        /// * AssetsUploaded<br/>
        /// * Deleted<br/>
        /// * Deprecated<br/>
        /// * InReview<br/>
        /// * InTest<br/>
        /// * PendingAction<br/>
        /// * Rejected<br/>
        /// * Released
        /// </param>
        /// <param name="subscriptionsSupportLevel">
        /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  <br/>
        ///   <br/>
        /// * none — The extension can't view the user’s subscription level.<br/>
        /// * optional — The extension can view the user’s subscription level.
        /// </param>
        /// <param name="summary">
        /// A short description of the extension that streamers see when hovering over the discovery splash screen in the Extensions manager.
        /// </param>
        /// <param name="supportEmail">
        /// The email address that users use to get support for the extension.
        /// </param>
        /// <param name="version">
        /// The extension’s version number.
        /// </param>
        /// <param name="viewerSummary">
        /// A brief description displayed on the channel to explain how the extension works.
        /// </param>
        /// <param name="views">
        /// Describes all views-related information such as how the extension is displayed on mobile devices.
        /// </param>
        /// <param name="allowlistedConfigUrls">
        /// Allowlisted configuration URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </param>
        /// <param name="allowlistedPanelUrls">
        /// Allowlisted panel URLs for displaying the extension (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Capabilities**).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Extension(
            string authorName,
            bool bitsEnabled,
            bool canInstall,
            global::G.ExtensionConfigurationLocation configurationLocation,
            string description,
            string eulaTosUrl,
            bool hasChatSupport,
            string iconUrl,
            global::G.ExtensionIconUrls iconUrls,
            string id,
            string name,
            string privacyPolicyUrl,
            bool requestIdentityLink,
            global::System.Collections.Generic.IList<string> screenshotUrls,
            global::G.ExtensionState state,
            global::G.ExtensionSubscriptionsSupportLevel subscriptionsSupportLevel,
            string summary,
            string supportEmail,
            string version,
            string viewerSummary,
            global::G.ExtensionViews views,
            global::System.Collections.Generic.IList<string> allowlistedConfigUrls,
            global::System.Collections.Generic.IList<string> allowlistedPanelUrls)
        {
            this.AuthorName = authorName ?? throw new global::System.ArgumentNullException(nameof(authorName));
            this.BitsEnabled = bitsEnabled;
            this.CanInstall = canInstall;
            this.ConfigurationLocation = configurationLocation;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.EulaTosUrl = eulaTosUrl ?? throw new global::System.ArgumentNullException(nameof(eulaTosUrl));
            this.HasChatSupport = hasChatSupport;
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.IconUrls = iconUrls ?? throw new global::System.ArgumentNullException(nameof(iconUrls));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrivacyPolicyUrl = privacyPolicyUrl ?? throw new global::System.ArgumentNullException(nameof(privacyPolicyUrl));
            this.RequestIdentityLink = requestIdentityLink;
            this.ScreenshotUrls = screenshotUrls ?? throw new global::System.ArgumentNullException(nameof(screenshotUrls));
            this.State = state;
            this.SubscriptionsSupportLevel = subscriptionsSupportLevel;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.SupportEmail = supportEmail ?? throw new global::System.ArgumentNullException(nameof(supportEmail));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ViewerSummary = viewerSummary ?? throw new global::System.ArgumentNullException(nameof(viewerSummary));
            this.Views = views ?? throw new global::System.ArgumentNullException(nameof(views));
            this.AllowlistedConfigUrls = allowlistedConfigUrls ?? throw new global::System.ArgumentNullException(nameof(allowlistedConfigUrls));
            this.AllowlistedPanelUrls = allowlistedPanelUrls ?? throw new global::System.ArgumentNullException(nameof(allowlistedPanelUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extension" /> class.
        /// </summary>
        public Extension()
        {
        }
    }
}