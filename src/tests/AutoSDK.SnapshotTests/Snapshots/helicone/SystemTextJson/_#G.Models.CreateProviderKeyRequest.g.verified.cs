//HintName: G.Models.CreateProviderKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProviderKeyRequest
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byokEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ByokEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKeyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSecretKey")]
        public string? ProviderSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderKeyRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="byokEnabled"></param>
        /// <param name="providerKeyName"></param>
        /// <param name="providerKey"></param>
        /// <param name="providerName"></param>
        /// <param name="providerSecretKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProviderKeyRequest(
            global::System.Collections.Generic.Dictionary<string, string> config,
            bool byokEnabled,
            string providerKeyName,
            string providerKey,
            string providerName,
            string? providerSecretKey)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ByokEnabled = byokEnabled;
            this.ProviderKeyName = providerKeyName ?? throw new global::System.ArgumentNullException(nameof(providerKeyName));
            this.ProviderSecretKey = providerSecretKey;
            this.ProviderKey = providerKey ?? throw new global::System.ArgumentNullException(nameof(providerKey));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderKeyRequest" /> class.
        /// </summary>
        public CreateProviderKeyRequest()
        {
        }
    }
}