//HintName: G.Models.GetAnimationsResponseDtoAnimationErrorVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseDtoAnimationErrorVariant5
    {
        /// <summary>
        /// Default Value: VideoEnhanceError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Failed to create enhanced video (logo, subsample)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant5" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: VideoEnhanceError
        /// </param>
        /// <param name="description">
        /// Default Value: Failed to create enhanced video (logo, subsample)
        /// </param>
        public GetAnimationsResponseDtoAnimationErrorVariant5(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant5" /> class.
        /// </summary>
        public GetAnimationsResponseDtoAnimationErrorVariant5()
        {
        }
    }
}