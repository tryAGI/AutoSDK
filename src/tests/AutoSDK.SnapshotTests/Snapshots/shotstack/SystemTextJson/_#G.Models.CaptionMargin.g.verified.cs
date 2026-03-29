//HintName: G.Models.CaptionMargin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The margin properties for captions. Margins are used to position the caption text and background on the screen.
    /// </summary>
    public sealed partial class CaptionMargin
    {
        /// <summary>
        /// The margin above the text. Pushes captions down the screen.<br/>
        /// Example: 0.25F
        /// </summary>
        /// <example>0.25F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        public double? Top { get; set; }

        /// <summary>
        /// The margin to the left of the text. Pushes captions to the right.<br/>
        /// Example: 0.05F
        /// </summary>
        /// <example>0.05F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public double? Left { get; set; }

        /// <summary>
        /// The margin to the right of the text. Pushes captions to the left.<br/>
        /// Example: 0.45F
        /// </summary>
        /// <example>0.45F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public double? Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionMargin" /> class.
        /// </summary>
        /// <param name="top">
        /// The margin above the text. Pushes captions down the screen.<br/>
        /// Example: 0.25F
        /// </param>
        /// <param name="left">
        /// The margin to the left of the text. Pushes captions to the right.<br/>
        /// Example: 0.05F
        /// </param>
        /// <param name="right">
        /// The margin to the right of the text. Pushes captions to the left.<br/>
        /// Example: 0.45F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionMargin(
            double? top,
            double? left,
            double? right)
        {
            this.Top = top;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionMargin" /> class.
        /// </summary>
        public CaptionMargin()
        {
        }
    }
}