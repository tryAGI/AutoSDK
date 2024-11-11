//HintName: G.Models.BaseModelCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseModelCard
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelCapabilities Capabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation")]
        public global::System.DateTime? Deprecation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: mistralai
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Default Value: base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseModelCardType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModelCard" /> class.
        /// </summary>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="capabilities"></param>
        /// <param name="created"></param>
        /// <param name="deprecation"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="ownedBy">
        /// Default Value: mistralai
        /// </param>
        /// <param name="type">
        /// Default Value: base
        /// </param>
        public BaseModelCard(
            global::G.ModelCapabilities capabilities,
            string id,
            global::System.Collections.Generic.IList<string>? aliases,
            int? created,
            global::System.DateTime? deprecation,
            string? description,
            int? maxContextLength,
            string? name,
            string? @object,
            string? ownedBy,
            global::G.BaseModelCardType? type)
        {
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Aliases = aliases;
            this.Created = created;
            this.Deprecation = deprecation;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.Name = name;
            this.Object = @object;
            this.OwnedBy = ownedBy;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModelCard" /> class.
        /// </summary>
        public BaseModelCard()
        {
        }
    }
}