//HintName: G.Models.PatchOrgProjectConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrgProjectConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_2FA_enabled")]
        public bool? Is2faEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_secret_keys_in_connected_account")]
        public bool? MaskSecretKeysInConnectedAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_visibility_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchOrgProjectConfigRequestLogVisibilitySettingJsonConverter))]
        public global::G.PatchOrgProjectConfigRequestLogVisibilitySetting? LogVisibilitySetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_mcp_api_key")]
        public bool? RequireMcpApiKey { get; set; }

        /// <summary>
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_link_enabled_for_managed_auth")]
        public bool? IsComposioLinkEnabledForManagedAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url_file_expiry_in_seconds")]
        public double? SignedUrlFileExpiryInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrgProjectConfigRequest" /> class.
        /// </summary>
        /// <param name="is2faEnabled"></param>
        /// <param name="logoUrl"></param>
        /// <param name="displayName"></param>
        /// <param name="maskSecretKeysInConnectedAccount"></param>
        /// <param name="logVisibilitySetting"></param>
        /// <param name="requireMcpApiKey"></param>
        /// <param name="isComposioLinkEnabledForManagedAuth">
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </param>
        /// <param name="signedUrlFileExpiryInSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrgProjectConfigRequest(
            bool? is2faEnabled,
            string? logoUrl,
            string? displayName,
            bool? maskSecretKeysInConnectedAccount,
            global::G.PatchOrgProjectConfigRequestLogVisibilitySetting? logVisibilitySetting,
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
        /// Initializes a new instance of the <see cref="PatchOrgProjectConfigRequest" /> class.
        /// </summary>
        public PatchOrgProjectConfigRequest()
        {
        }
    }
}