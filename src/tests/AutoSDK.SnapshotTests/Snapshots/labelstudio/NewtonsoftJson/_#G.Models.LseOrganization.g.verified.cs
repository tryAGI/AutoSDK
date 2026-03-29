//HintName: G.Models.LseOrganization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseOrganization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationBilling Billing { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("custom_scripts_enabled")]
        public string CustomScriptsEnabled { get; set; } = default!;

        /// <summary>
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_role")]
        public global::G.Role9e7Enum? DefaultRole { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("email_notification_settings")]
        public string EmailNotificationSettings { get; set; } = default!;

        /// <summary>
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_domains")]
        public object? EmbedDomains { get; set; }

        /// <summary>
        /// Embed settings for this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// External ID to uniquely identify this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganization" /> class.
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="defaultRole">
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="embedDomains">
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </param>
        /// <param name="embedSettings">
        /// Embed settings for this organization
        /// </param>
        /// <param name="externalId">
        /// External ID to uniquely identify this organization
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="customScriptsEnabled">
        /// Included only in responses
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Included only in responses
        /// </param>
        /// <param name="token">
        /// Included only in responses
        /// </param>
        public LseOrganization(
            global::G.OrganizationBilling billing,
            global::G.Role9e7Enum? defaultRole,
            object? embedDomains,
            object? embedSettings,
            string? externalId,
            global::System.DateTime createdAt = default!,
            string customScriptsEnabled = default!,
            string emailNotificationSettings = default!,
            int id = default!,
            string title = default!,
            string token = default!)
        {
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
            this.CreatedAt = createdAt;
            this.CustomScriptsEnabled = customScriptsEnabled;
            this.DefaultRole = defaultRole;
            this.EmailNotificationSettings = emailNotificationSettings;
            this.EmbedDomains = embedDomains;
            this.EmbedSettings = embedSettings;
            this.ExternalId = externalId;
            this.Id = id;
            this.Title = title;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganization" /> class.
        /// </summary>
        public LseOrganization()
        {
        }
    }
}