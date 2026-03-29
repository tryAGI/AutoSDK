//HintName: G.Models.CredentialWebhookDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialWebhookDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CredentialWebhookDTOType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CredentialWebhookDTOOperation Operation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authMode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CredentialWebhookDTOAuthMode AuthMode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerConfigKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderConfigKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endUser", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CredentialEndUser EndUser { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.CredentialSessionError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialWebhookDTO" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="operation"></param>
        /// <param name="from"></param>
        /// <param name="connectionId"></param>
        /// <param name="authMode"></param>
        /// <param name="providerConfigKey"></param>
        /// <param name="provider"></param>
        /// <param name="environment"></param>
        /// <param name="success"></param>
        /// <param name="endUser"></param>
        /// <param name="error"></param>
        /// <param name="tags"></param>
        public CredentialWebhookDTO(
            global::G.CredentialWebhookDTOType type,
            global::G.CredentialWebhookDTOOperation operation,
            string from,
            string connectionId,
            global::G.CredentialWebhookDTOAuthMode authMode,
            string providerConfigKey,
            string provider,
            string environment,
            bool success,
            global::G.CredentialEndUser endUser,
            global::G.CredentialSessionError? error,
            object? tags)
        {
            this.Type = type;
            this.Operation = operation;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.AuthMode = authMode;
            this.ProviderConfigKey = providerConfigKey ?? throw new global::System.ArgumentNullException(nameof(providerConfigKey));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Success = success;
            this.EndUser = endUser ?? throw new global::System.ArgumentNullException(nameof(endUser));
            this.Error = error;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialWebhookDTO" /> class.
        /// </summary>
        public CredentialWebhookDTO()
        {
        }
    }
}