//HintName: G.Models.RiggingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RiggingRequest
    {
        /// <summary>
        /// ID of completed task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_task_id")]
        public string? InputTaskId { get; set; }

        /// <summary>
        /// Public URL or data URI to GLB file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// Character height in meters<br/>
        /// Default Value: 1.7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height_meters")]
        public double? HeightMeters { get; set; }

        /// <summary>
        /// UV-unwrapped base color texture (PNG)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_image_url")]
        public string? TextureImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingRequest" /> class.
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI to GLB file
        /// </param>
        /// <param name="heightMeters">
        /// Character height in meters<br/>
        /// Default Value: 1.7
        /// </param>
        /// <param name="textureImageUrl">
        /// UV-unwrapped base color texture (PNG)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RiggingRequest(
            string? inputTaskId,
            string? modelUrl,
            double? heightMeters,
            string? textureImageUrl)
        {
            this.InputTaskId = inputTaskId;
            this.ModelUrl = modelUrl;
            this.HeightMeters = heightMeters;
            this.TextureImageUrl = textureImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingRequest" /> class.
        /// </summary>
        public RiggingRequest()
        {
        }
    }
}