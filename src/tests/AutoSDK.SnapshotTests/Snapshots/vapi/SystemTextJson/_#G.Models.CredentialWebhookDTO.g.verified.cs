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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CredentialWebhookDTOTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CredentialWebhookDTOType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CredentialWebhookDTOOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CredentialWebhookDTOOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CredentialWebhookDTOAuthModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CredentialWebhookDTOAuthMode AuthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerConfigKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderConfigKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CredentialEndUser EndUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.CredentialSessionError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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