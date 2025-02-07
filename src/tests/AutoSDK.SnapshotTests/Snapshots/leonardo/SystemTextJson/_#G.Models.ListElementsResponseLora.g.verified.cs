//HintName: G.Models.ListElementsResponseLora.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "elements"
    /// </summary>
    public sealed partial class ListElementsResponseLora
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public global::G.Lora? AkUUID { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdVersionsJsonConverter))]
        public global::G.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public global::G.Lora? CreatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.Lora? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::G.Lora? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlImage")]
        public global::G.Lora? UrlImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public global::G.Lora? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public global::G.Lora? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public global::G.Lora? WeightMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponseLora" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="baseModel">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="creatorName"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="urlImage"></param>
        /// <param name="weightDefault"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightMin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListElementsResponseLora(
            global::G.Lora? akUUID,
            global::G.SdVersions? baseModel,
            global::G.Lora? creatorName,
            global::G.Lora? description,
            global::G.Lora? name,
            global::G.Lora? urlImage,
            global::G.Lora? weightDefault,
            global::G.Lora? weightMax,
            global::G.Lora? weightMin)
        {
            this.AkUUID = akUUID;
            this.BaseModel = baseModel;
            this.CreatorName = creatorName;
            this.Description = description;
            this.Name = name;
            this.UrlImage = urlImage;
            this.WeightDefault = weightDefault;
            this.WeightMax = weightMax;
            this.WeightMin = weightMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponseLora" /> class.
        /// </summary>
        public ListElementsResponseLora()
        {
        }
    }
}