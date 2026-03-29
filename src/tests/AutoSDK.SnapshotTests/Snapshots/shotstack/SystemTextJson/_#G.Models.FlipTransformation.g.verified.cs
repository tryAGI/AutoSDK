//HintName: G.Models.FlipTransformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flip a clip vertically or horizontally. Acts as a mirror effect of the clip along the selected plane.
    /// </summary>
    public sealed partial class FlipTransformation
    {
        /// <summary>
        /// Flip a clip horizontally.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal")]
        public bool? Horizontal { get; set; }

        /// <summary>
        /// Flip a clip vertically.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical")]
        public bool? Vertical { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlipTransformation" /> class.
        /// </summary>
        /// <param name="horizontal">
        /// Flip a clip horizontally.<br/>
        /// Example: true
        /// </param>
        /// <param name="vertical">
        /// Flip a clip vertically.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlipTransformation(
            bool? horizontal,
            bool? vertical)
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlipTransformation" /> class.
        /// </summary>
        public FlipTransformation()
        {
        }
    }
}