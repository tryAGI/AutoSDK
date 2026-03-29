//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication configuration
    /// </summary>
    public sealed partial class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth(
            string secretId)
        {
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth" /> class.
        /// </summary>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth()
        {
        }
    }
}