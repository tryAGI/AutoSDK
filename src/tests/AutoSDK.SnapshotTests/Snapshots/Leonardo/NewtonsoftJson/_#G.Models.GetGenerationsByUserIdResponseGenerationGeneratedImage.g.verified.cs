//HintName: G.Models.GetGenerationsByUserIdResponseGenerationGeneratedImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_images"
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponseGenerationGeneratedImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_image_variation_generics")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? GeneratedImageVariationGenerics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// If it is an image to video generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageToVideo")]
        public bool? ImageToVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("likeCount")]
        public int? LikeCount { get; set; }

        /// <summary>
        /// If generation is of motion type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motion")]
        public bool? Motion { get; set; }

        /// <summary>
        /// The name of the motion model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motionModel")]
        public string? MotionModel { get; set; }

        /// <summary>
        /// The URL of the motion MP4.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motionMP4URL")]
        public string? MotionMP4URL { get; set; }

        /// <summary>
        /// The motion strength.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motionStrength")]
        public int? MotionStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nsfw")]
        public bool? Nsfw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGeneratedImage" /> class.
        /// </summary>
        /// <param name="generatedImageVariationGenerics"></param>
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
        public GetGenerationsByUserIdResponseGenerationGeneratedImage(
            global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? generatedImageVariationGenerics,
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
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGeneratedImage" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponseGenerationGeneratedImage()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage?>(serializer.Deserialize<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage>(jsonReader));
        }

    }
}