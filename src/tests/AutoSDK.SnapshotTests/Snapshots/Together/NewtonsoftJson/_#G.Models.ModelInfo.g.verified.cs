//HintName: G.Models.ModelInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::Newtonsoft.Json.JsonProperty("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// Example: 1692896905
        /// </summary>
        /// <example>1692896905</example>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// Example: Chronos Hermes (13B)
        /// </summary>
        /// <example>Chronos Hermes (13B)</example>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Example: Austism/chronos-hermes-13b
        /// </summary>
        /// <example>Austism/chronos-hermes-13b</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: other
        /// </summary>
        /// <example>other</example>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Example: Austism
        /// </summary>
        /// <example>Austism</example>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing")]
        public global::G.Pricing? Pricing { get; set; }

        /// <summary>
        /// Example: chat
        /// </summary>
        /// <example>chat</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelInfoType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="contextLength">
        /// Example: 2048
        /// </param>
        /// <param name="created">
        /// Example: 1692896905
        /// </param>
        /// <param name="displayName">
        /// Example: Chronos Hermes (13B)
        /// </param>
        /// <param name="id">
        /// Example: Austism/chronos-hermes-13b
        /// </param>
        /// <param name="license">
        /// Example: other
        /// </param>
        /// <param name="link"></param>
        /// <param name="object">
        /// Example: model
        /// </param>
        /// <param name="organization">
        /// Example: Austism
        /// </param>
        /// <param name="pricing"></param>
        /// <param name="type">
        /// Example: chat
        /// </param>
        public ModelInfo(
            int created,
            string id,
            string @object,
            global::G.ModelInfoType type,
            int? contextLength,
            string? displayName,
            string? license,
            string? link,
            string? organization,
            global::G.Pricing? pricing)
        {
            this.Created = created;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Type = type;
            this.ContextLength = contextLength;
            this.DisplayName = displayName;
            this.License = license;
            this.Link = link;
            this.Organization = organization;
            this.Pricing = pricing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}