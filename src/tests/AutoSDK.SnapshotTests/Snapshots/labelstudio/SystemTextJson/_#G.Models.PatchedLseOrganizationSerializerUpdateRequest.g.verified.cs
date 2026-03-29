//HintName: G.Models.PatchedLseOrganizationSerializerUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A serializer mixin that takes an additional `fields` argument that controls<br/>
    /// which fields should be displayed.
    /// </summary>
    public sealed partial class PatchedLseOrganizationSerializerUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public string? ContactInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Plugins<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_scripts_enabled")]
        public bool? CustomScriptsEnabled { get; set; }

        /// <summary>
        /// Email Notification Settings<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_notification_settings")]
        public object? EmailNotificationSettings { get; set; }

        /// <summary>
        /// Supported domains<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_domains")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? EmbedDomains { get; set; }

        /// <summary>
        /// Public Verification Key and Public Verification Algorithms configuration<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// Organization name<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseOrganizationSerializerUpdateRequest" /> class.
        /// </summary>
        /// <param name="contactInfo"></param>
        /// <param name="createdBy"></param>
        /// <param name="customScriptsEnabled">
        /// Plugins<br/>
        /// Included only in requests
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Email Notification Settings<br/>
        /// Included only in requests
        /// </param>
        /// <param name="embedDomains">
        /// Supported domains<br/>
        /// Included only in requests
        /// </param>
        /// <param name="embedSettings">
        /// Public Verification Key and Public Verification Algorithms configuration<br/>
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Organization name<br/>
        /// Included only in requests
        /// </param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLseOrganizationSerializerUpdateRequest(
            string? contactInfo,
            int? createdBy,
            bool? customScriptsEnabled,
            object? emailNotificationSettings,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? embedDomains,
            object? embedSettings,
            string? title,
            string? token)
        {
            this.ContactInfo = contactInfo;
            this.CreatedBy = createdBy;
            this.CustomScriptsEnabled = customScriptsEnabled;
            this.EmailNotificationSettings = emailNotificationSettings;
            this.EmbedDomains = embedDomains;
            this.EmbedSettings = embedSettings;
            this.Title = title;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseOrganizationSerializerUpdateRequest" /> class.
        /// </summary>
        public PatchedLseOrganizationSerializerUpdateRequest()
        {
        }
    }
}