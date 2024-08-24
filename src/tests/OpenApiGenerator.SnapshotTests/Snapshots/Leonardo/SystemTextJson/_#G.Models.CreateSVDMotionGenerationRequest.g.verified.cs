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
    }
}