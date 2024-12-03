//HintName: G.Models.Lora.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lora
    {
        /// <summary>
        /// Unique identifier for the element. Elements can be found from the List Elements endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// Name of the creator of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// Name of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the element image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlImage")]
        public string? UrlImage { get; set; }

        /// <summary>
        /// Base model version for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Default weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightDefault")]
        public int? WeightDefault { get; set; }

        /// <summary>
        /// Minimum weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMin")]
        public int? WeightMin { get; set; }

        /// <summary>
        /// Maximum weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMax")]
        public int? WeightMax { get; set; }

        /// <summary>
        /// Type name for introspection purposes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("__typename")]
        public string? Typename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Lora" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// Unique identifier for the element. Elements can be found from the List Elements endpoint.
        /// </param>
        /// <param name="creatorName">
        /// Name of the creator of the element
        /// </param>
        /// <param name="name">
        /// Name of the element
        /// </param>
        /// <param name="description">
        /// Description for the element
        /// </param>
        /// <param name="urlImage">
        /// URL of the element image
        /// </param>
        /// <param name="baseModel">
        /// Base model version for the element
        /// </param>
        /// <param name="weightDefault">
        /// Default weight for the element
        /// </param>
        /// <param name="weightMin">
        /// Minimum weight for the element
        /// </param>
        /// <param name="weightMax">
        /// Maximum weight for the element
        /// </param>
        /// <param name="typename">
        /// Type name for introspection purposes
        /// </param>
        public Lora(
            string? akUUID,
            string? creatorName,
            string? name,
            string? description,
            string? urlImage,
            string? baseModel,
            int? weightDefault,
            int? weightMin,
            int? weightMax,
            string? typename)
        {
            this.AkUUID = akUUID;
            this.CreatorName = creatorName;
            this.Name = name;
            this.Description = description;
            this.UrlImage = urlImage;
            this.BaseModel = baseModel;
            this.WeightDefault = weightDefault;
            this.WeightMin = weightMin;
            this.WeightMax = weightMax;
            this.Typename = typename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lora" /> class.
        /// </summary>
        public Lora()
        {
        }
    }
}