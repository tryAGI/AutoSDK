//HintName: G.Models.PostOrgOwnerProjectNewRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the project
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_2FA_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Is2faEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_secret_keys_in_connected_account", Required = global::Newtonsoft.Json.Required.Always)]
        public bool MaskSecretKeysInConnectedAccount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_visibility_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting LogVisibilitySetting { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_mcp_api_key")]
        public bool? RequireMcpApiKey { get; set; }

        /// <summary>
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_composio_link_enabled_for_managed_auth")]
        public bool? IsComposioLinkEnabledForManagedAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_url_file_expiry_in_seconds")]
        public double? SignedUrlFileExpiryInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestConfig" /> class.
        /// </summary>
        /// <param name="is2faEnabled"></param>
        /// <param name="maskSecretKeysInConnectedAccount"></param>
        /// <param name="logVisibilitySetting"></param>
        /// <param name="logoUrl"></param>
        /// <param name="displayName"></param>
        /// <param name="requireMcpApiKey"></param>
        /// <param name="isComposioLinkEnabledForManagedAuth">
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </param>
        /// <param name="signedUrlFileExpiryInSeconds"></param>
        public PostOrgOwnerProjectNewRequestConfig(
            bool is2faEnabled,
            bool maskSecretKeysInConnectedAccount,
            global::G.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting logVisibilitySetting,
            string? logoUrl,
            string? displayName,
            bool? requireMcpApiKey,
            bool? isComposioLinkEnabledForManagedAuth,
            double? signedUrlFileExpiryInSeconds)
        {
            this.Is2faEnabled = is2faEnabled;
            this.LogoUrl = logoUrl;
            this.DisplayName = displayName;
            this.MaskSecretKeysInConnectedAccount = maskSecretKeysInConnectedAccount;
            this.LogVisibilitySetting = logVisibilitySetting;
            this.RequireMcpApiKey = requireMcpApiKey;
            this.IsComposioLinkEnabledForManagedAuth = isComposioLinkEnabledForManagedAuth;
            this.SignedUrlFileExpiryInSeconds = signedUrlFileExpiryInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestConfig" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewRequestConfig()
        {
        }
    }
}