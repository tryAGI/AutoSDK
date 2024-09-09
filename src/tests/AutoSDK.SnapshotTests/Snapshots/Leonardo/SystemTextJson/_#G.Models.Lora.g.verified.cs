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
    }
}