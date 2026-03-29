//HintName: G.Models.GeneratedImageInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedImageInputs
    {
        /// <summary>
        /// Prompt for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// The id of the model used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// Aspect ratio used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Resolution used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// The id of the Image asset used as the start keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_keyframe_id")]
        public global::System.Guid? StartKeyframeId { get; set; }

        /// <summary>
        /// The id(s) of the image(s) referenced in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImageInputs" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Prompt for image generation.
        /// </param>
        /// <param name="aiModelId">
        /// The id of the model used for generation.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio used for generation.
        /// </param>
        /// <param name="resolution">
        /// Resolution used for generation.
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the Image asset used as the start keyframe.
        /// </param>
        /// <param name="referenceImageIds">
        /// The id(s) of the image(s) referenced in the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedImageInputs(
            string textPrompt,
            global::System.Guid? aiModelId,
            string? aspectRatio,
            string? resolution,
            global::System.Guid? startKeyframeId,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.AiModelId = aiModelId;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.StartKeyframeId = startKeyframeId;
            this.ReferenceImageIds = referenceImageIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImageInputs" /> class.
        /// </summary>
        public GeneratedImageInputs()
        {
        }
    }
}