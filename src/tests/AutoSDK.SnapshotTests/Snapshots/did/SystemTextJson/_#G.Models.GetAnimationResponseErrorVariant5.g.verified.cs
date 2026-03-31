//HintName: G.Models.GetAnimationResponseErrorVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationResponseErrorVariant5
    {
        /// <summary>
        /// Default Value: VideoEnhanceError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Failed to create enhanced video (logo, subsample)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationResponseErrorVariant5" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: VideoEnhanceError
        /// </param>
        /// <param name="description">
        /// Default Value: Failed to create enhanced video (logo, subsample)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationResponseErrorVariant5(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationResponseErrorVariant5" /> class.
        /// </summary>
        public GetAnimationResponseErrorVariant5()
        {
        }
    }
}