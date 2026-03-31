//HintName: G.Models.CreateClipStreamRequestPresenterConfigCropVariant2Rectangle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
    /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
    /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
    /// </summary>
    public sealed partial class CreateClipStreamRequestPresenterConfigCropVariant2Rectangle
    {
        /// <summary>
        /// Bottom position.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Bottom { get; set; }

        /// <summary>
        /// Right position.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Right { get; set; }

        /// <summary>
        /// Left position.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Left { get; set; }

        /// <summary>
        /// Top position.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Top { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfigCropVariant2Rectangle" /> class.
        /// </summary>
        /// <param name="bottom">
        /// Bottom position.<br/>
        /// Example: 1
        /// </param>
        /// <param name="right">
        /// Right position.<br/>
        /// Example: 1
        /// </param>
        /// <param name="left">
        /// Left position.<br/>
        /// Example: 0
        /// </param>
        /// <param name="top">
        /// Top position.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequestPresenterConfigCropVariant2Rectangle(
            double bottom,
            double right,
            double left,
            double top)
        {
            this.Bottom = bottom;
            this.Right = right;
            this.Left = left;
            this.Top = top;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfigCropVariant2Rectangle" /> class.
        /// </summary>
        public CreateClipStreamRequestPresenterConfigCropVariant2Rectangle()
        {
        }
    }
}