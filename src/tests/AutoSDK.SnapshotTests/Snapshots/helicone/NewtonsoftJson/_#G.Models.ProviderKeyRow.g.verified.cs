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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKeyName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_delete", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SoftDelete { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.RecordStringAny? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_enabled")]
        public bool? ByokEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cuid")]
        public string? Cuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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