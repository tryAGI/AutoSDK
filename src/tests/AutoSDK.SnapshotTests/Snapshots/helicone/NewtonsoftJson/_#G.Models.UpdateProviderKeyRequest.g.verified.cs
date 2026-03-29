//HintName: G.Models.UpdateProviderKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProviderKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byokEnabled")]
        public bool? ByokEnabled { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerSecretKey")]
        public string? ProviderSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKey")]
        public string? ProviderKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProviderKeyRequest" /> class.
        /// </summary>
        /// <param name="byokEnabled"></param>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="providerSecretKey"></param>
        /// <param name="providerKey"></param>
        public UpdateProviderKeyRequest(
            bool? byokEnabled,
            global::System.Collections.Generic.Dictionary<string, string>? config,
            string? providerSecretKey,
            string? providerKey)
        {
            this.ByokEnabled = byokEnabled;
            this.Config = config;
            this.ProviderSecretKey = providerSecretKey;
            this.ProviderKey = providerKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProviderKeyRequest" /> class.
        /// </summary>
        public UpdateProviderKeyRequest()
        {
        }
    }
}