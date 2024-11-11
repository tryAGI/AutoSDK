//HintName: G.Models.CreateSVDMotionGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSVDMotionGenerationRequest
    {
        /// <summary>
        /// The ID of the image, supports generated images, variation images, and init images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        /// Whether the generation is public or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// If it is an init image uploaded by the user. This image is uploaded from endpoint: Upload init image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInitImage")]
        public bool? IsInitImage { get; set; }

        /// <summary>
        /// If it is a variation image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVariation")]
        public bool? IsVariation { get; set; }

        /// <summary>
        /// The motion strength.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionStrength")]
        public int? MotionStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationRequest" /> class.
        /// </summary>
        /// <param name="imageId">
        /// The ID of the image, supports generated images, variation images, and init images.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="isInitImage">
        /// If it is an init image uploaded by the user. This image is uploaded from endpoint: Upload init image.
        /// </param>
        /// <param name="isVariation">
        /// If it is a variation image.
        /// </param>
        /// <param name="motionStrength">
        /// The motion strength.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateSVDMotionGenerationRequest(
            string imageId,
            bool? isPublic,
            bool? isInitImage,
            bool? isVariation,
            int? motionStrength)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.IsPublic = isPublic;
            this.IsInitImage = isInitImage;
            this.IsVariation = isVariation;
            this.MotionStrength = motionStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationRequest" /> class.
        /// </summary>
        public CreateSVDMotionGenerationRequest()
        {
        }
    }
}