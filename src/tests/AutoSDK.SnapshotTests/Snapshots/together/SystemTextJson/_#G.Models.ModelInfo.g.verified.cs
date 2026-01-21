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
        /// Example: Austism/chronos-hermes-13b
        /// </summary>
        /// <example>Austism/chronos-hermes-13b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Example: 1692896905
        /// </summary>
        /// <example>1692896905</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// Example: chat
        /// </summary>
        /// <example>chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelInfoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelInfoType Type { get; set; }

        /// <summary>
        /// Example: Chronos Hermes (13B)
        /// </summary>
        /// <example>Chronos Hermes (13B)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Example: Austism
        /// </summary>
        /// <example>Austism</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Example: other
        /// </summary>
        /// <example>other</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::G.Pricing? Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: Austism/chronos-hermes-13b
        /// </param>
        /// <param name="object">
        /// Example: model
        /// </param>
        /// <param name="created">
        /// Example: 1692896905
        /// </param>
        /// <param name="type">
        /// Example: chat
        /// </param>
        /// <param name="displayName">
        /// Example: Chronos Hermes (13B)
        /// </param>
        /// <param name="organization">
        /// Example: Austism
        /// </param>
        /// <param name="link"></param>
        /// <param name="license">
        /// Example: other
        /// </param>
        /// <param name="contextLength">
        /// Example: 2048
        /// </param>
        /// <param name="pricing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfo(
            string id,
            string @object,
            int created,
            global::G.ModelInfoType type,
            string? displayName,
            string? organization,
            string? link,
            string? license,
            int? contextLength,
            global::G.Pricing? pricing)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Created = created;
            this.Type = type;
            this.DisplayName = displayName;
            this.Organization = organization;
            this.Link = link;
            this.License = license;
            this.ContextLength = contextLength;
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