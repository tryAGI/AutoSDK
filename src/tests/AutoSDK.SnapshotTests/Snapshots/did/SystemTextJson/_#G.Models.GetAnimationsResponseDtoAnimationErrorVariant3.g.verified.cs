//HintName: G.Models.GetAnimationsResponseDtoAnimationErrorVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseDtoAnimationErrorVariant3
    {
        /// <summary>
        /// Default Value: SourceError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Could not load source image or invalid format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant3" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: SourceError
        /// </param>
        /// <param name="description">
        /// Default Value: Could not load source image or invalid format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationsResponseDtoAnimationErrorVariant3(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant3" /> class.
        /// </summary>
        public GetAnimationsResponseDtoAnimationErrorVariant3()
        {
        }
    }
}