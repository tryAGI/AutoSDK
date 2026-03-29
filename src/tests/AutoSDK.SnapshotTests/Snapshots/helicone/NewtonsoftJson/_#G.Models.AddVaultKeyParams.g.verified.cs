//HintName: G.Models.AddVaultKeyParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddVaultKeyParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVaultKeyParams" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        public AddVaultKeyParams(
            string key,
            string provider,
            string? name)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVaultKeyParams" /> class.
        /// </summary>
        public AddVaultKeyParams()
        {
        }
    }
}