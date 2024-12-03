//HintName: G.Models.ListPlatformModelsResponseCustomModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "custom_models"
    /// </summary>
    public sealed partial class ListPlatformModelsResponseCustomModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("featured")]
        public bool? Featured { get; set; }

        /// <summary>
        /// columns and relationships of "generated_images"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_image")]
        public global::G.ListPlatformModelsResponseCustomModelGeneratedImage? GeneratedImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nsfw")]
        public bool? Nsfw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponseCustomModel" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="featured"></param>
        /// <param name="generatedImage">
        /// columns and relationships of "generated_images"
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nsfw"></param>
        public ListPlatformModelsResponseCustomModel(
            string? description,
            bool? featured,
            global::G.ListPlatformModelsResponseCustomModelGeneratedImage? generatedImage,
            string? id,
            string? name,
            bool? nsfw)
        {
            this.Description = description;
            this.Featured = featured;
            this.GeneratedImage = generatedImage;
            this.Id = id;
            this.Name = name;
            this.Nsfw = nsfw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponseCustomModel" /> class.
        /// </summary>
        public ListPlatformModelsResponseCustomModel()
        {
        }
    }
}