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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        public bool? Featured { get; set; }

        /// <summary>
        /// columns and relationships of "generated_images"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image")]
        public global::G.ListPlatformModelsResponseCustomModelGeneratedImage? GeneratedImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw")]
        public bool? Nsfw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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