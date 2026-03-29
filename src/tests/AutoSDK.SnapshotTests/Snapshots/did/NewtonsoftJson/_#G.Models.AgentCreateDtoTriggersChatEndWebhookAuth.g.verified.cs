//HintName: G.Models.AgentCreateDtoTriggersChatEndWebhookAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication configuration
    /// </summary>
    public sealed partial class AgentCreateDtoTriggersChatEndWebhookAuth
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
        /// Initializes a new instance of the <see cref="AgentCreateDtoTriggersChatEndWebhookAuth" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        public AgentCreateDtoTriggersChatEndWebhookAuth(
            string secretId)
        {
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoTriggersChatEndWebhookAuth" /> class.
        /// </summary>
        public AgentCreateDtoTriggersChatEndWebhookAuth()
        {
        }
    }
}