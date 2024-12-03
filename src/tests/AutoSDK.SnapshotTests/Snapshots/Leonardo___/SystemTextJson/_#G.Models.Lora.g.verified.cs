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
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// Name of the creator of the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// Name of the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the element image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlImage")]
        public string? UrlImage { get; set; }

        /// <summary>
        /// Base model version for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Default weight for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public int? WeightDefault { get; set; }

        /// <summary>
        /// Minimum weight for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public int? WeightMin { get; set; }

        /// <summary>
        /// Maximum weight for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public int? WeightMax { get; set; }

        /// <summary>
        /// Type name for introspection purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__typename")]
        public string? Typename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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