//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant22.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom crop
    /// </summary>
    public sealed partial class CreateClipRequestPresenterConfigCropVariant22
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipRequestPresenterConfigCropVariant2Type2JsonConverter))]
        public global::G.CreateClipRequestPresenterConfigCropVariant2Type2 Type { get; set; }

        /// <summary>
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rectangle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateClipRequestPresenterConfigCropVariant2Rectangle2 Rectangle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfigCropVariant22" /> class.
        /// </summary>
        /// <param name="rectangle">
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </param>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipRequestPresenterConfigCropVariant22(
            global::G.CreateClipRequestPresenterConfigCropVariant2Rectangle2 rectangle,
            global::G.CreateClipRequestPresenterConfigCropVariant2Type2 type)
        {
            this.Type = type;
            this.Rectangle = rectangle ?? throw new global::System.ArgumentNullException(nameof(rectangle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfigCropVariant22" /> class.
        /// </summary>
        public CreateClipRequestPresenterConfigCropVariant22()
        {
        }
    }
}