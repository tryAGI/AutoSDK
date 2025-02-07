//HintName: G.Models.GetGenerationByIdResponseGenerationsByPkGeneratedImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_images"
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGeneratedImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image_variation_generics")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? GeneratedImageVariationGenerics { get; set; }

        /// <summary>
        /// If fantasyAvatar feature was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fantasyAvatar")]
        public bool? FantasyAvatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// If it is an image to video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageToVideo")]
        public bool? ImageToVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likeCount")]
        public int? LikeCount { get; set; }

        /// <summary>
        /// If generation is of motion type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motion")]
        public bool? Motion { get; set; }

        /// <summary>
        /// The name of the motion model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionModel")]
        public string? MotionModel { get; set; }

        /// <summary>
        /// The URL of the motion MP4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionMP4URL")]
        public string? MotionMP4URL { get; set; }

        /// <summary>
        /// The motion strength.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionStrength")]
        public int? MotionStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw")]
        public bool? Nsfw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGeneratedImage" /> class.
        /// </summary>
        /// <param name="generatedImageVariationGenerics"></param>
        /// <param name="fantasyAvatar">
        /// If fantasyAvatar feature was used.
        /// </param>
        /// <param name="id"></param>
        /// <param name="imageToVideo">
        /// If it is an image to video generation.
        /// </param>
        /// <param name="likeCount"></param>
        /// <param name="motion">
        /// If generation is of motion type.
        /// </param>
        /// <param name="motionModel">
        /// The name of the motion model.
        /// </param>
        /// <param name="motionMP4URL">
        /// The URL of the motion MP4.
        /// </param>
        /// <param name="motionStrength">
        /// The motion strength.
        /// </param>
        /// <param name="nsfw"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGenerationByIdResponseGenerationsByPkGeneratedImage(
            global::System.Collections.Generic.IList<global::G.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? generatedImageVariationGenerics,
            bool? fantasyAvatar,
            string? id,
            bool? imageToVideo,
            int? likeCount,
            bool? motion,
            string? motionModel,
            string? motionMP4URL,
            int? motionStrength,
            bool? nsfw,
            string? url)
        {
            this.GeneratedImageVariationGenerics = generatedImageVariationGenerics;
            this.FantasyAvatar = fantasyAvatar;
            this.Id = id;
            this.ImageToVideo = imageToVideo;
            this.LikeCount = likeCount;
            this.Motion = motion;
            this.MotionModel = motionModel;
            this.MotionMP4URL = motionMP4URL;
            this.MotionStrength = motionStrength;
            this.Nsfw = nsfw;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGeneratedImage" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGeneratedImage()
        {
        }
    }
}