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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVaultKeyParams" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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