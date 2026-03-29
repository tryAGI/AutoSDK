//HintName: G.Models.ProviderKeyRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderKeyRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SoftDelete { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.RecordStringAny? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_enabled")]
        public bool? ByokEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuid")]
        public string? Cuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyRow" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="providerName"></param>
        /// <param name="providerKeyName"></param>
        /// <param name="softDelete"></param>
        /// <param name="createdAt"></param>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="byokEnabled"></param>
        /// <param name="cuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderKeyRow(
            string id,
            string providerName,
            string providerKeyName,
            bool softDelete,
            string? createdAt,
            global::G.RecordStringAny? config,
            bool? byokEnabled,
            string? cuid)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderKeyName = providerKeyName ?? throw new global::System.ArgumentNullException(nameof(providerKeyName));
            this.CreatedAt = createdAt;
            this.SoftDelete = softDelete;
            this.Config = config;
            this.ByokEnabled = byokEnabled;
            this.Cuid = cuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyRow" /> class.
        /// </summary>
        public ProviderKeyRow()
        {
        }
    }
}