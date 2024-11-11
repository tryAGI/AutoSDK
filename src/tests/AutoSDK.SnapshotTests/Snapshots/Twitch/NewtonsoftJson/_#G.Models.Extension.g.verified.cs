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
        /// A Boolean value that determines whether a user can install the extension on their channel. Is **true** if a user can install the extension.  <br/>
        ///   <br/>
        /// Typically, this is set to **false** if the extension is currently in testing mode and requires users to be allowlisted (the allowlist is configured on Twitch’s [developer site](https://dev.twitch.tv/console/extensions) under the **Extensions** \-&gt; **Extension** \-&gt; **Version** \-&gt; **Access**).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_install", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanInstall { get; set; } = default!;

        /// <summary>
        /// The location of where the extension’s configuration is stored. Possible values are:  <br/>
        ///   <br/>
        /// * hosted — The Extensions Configuration Service hosts the configuration.<br/>
        /// * custom — The Extension Backend Service (EBS) hosts the configuration.<br/>
        /// * none — The extension doesn't require configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_location", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionConfigurationLocation ConfigurationLocation { get; set; } = default!;

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
        public global::G.ExtensionIconUrls IconUrls { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionState State { get; set; } = default!;

        /// <summary>
        /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  <br/>
        ///   <br/>
        /// * none — The extension can't view the user’s subscription level.<br/>
        /// * optional — The extension can view the user’s subscription level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_support_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionSubscriptionsSupportLevel SubscriptionsSupportLevel { get; set; } = default!;

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
        public global::G.ExtensionViews Views { get; set; } = default!;

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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Extension? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Extension>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Extension?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Extension?>(serializer.Deserialize<global::G.Extension>(jsonReader));
        }

    }
}