//HintName: G.Models.EditImageGetLayersVariant2ImageSegmentation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetLayersVariant2ImageSegmentation
    {
        /// <summary>
        /// Controls whether or not the salient object should be kept or ignored by the segmentation model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageSegmentationModeJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageSegmentationMode? Mode { get; set; }

        /// <summary>
        /// A textual description of what the segmentation should remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// A textual description of what the segmentation should keep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2ImageSegmentation" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A textual description of what the segmentation should keep.
        /// </param>
        /// <param name="mode">
        /// Controls whether or not the salient object should be kept or ignored by the segmentation model.
        /// </param>
        /// <param name="negativePrompt">
        /// A textual description of what the segmentation should remove.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetLayersVariant2ImageSegmentation(
            string prompt,
            global::G.EditImageGetLayersVariant2ImageSegmentationMode? mode,
            string? negativePrompt)
        {
            this.Mode = mode;
            this.NegativePrompt = negativePrompt;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2ImageSegmentation" /> class.
        /// </summary>
        public EditImageGetLayersVariant2ImageSegmentation()
        {
        }
    }
}