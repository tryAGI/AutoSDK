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
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byokEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ByokEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKeyName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKeyName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerSecretKey")]
        public string? ProviderSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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