//HintName: G.Models.GetAnimationsResponseDtoAnimationErrorVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseDtoAnimationErrorVariant2
    {
        /// <summary>
        /// Default Value: LogoError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Could not load logo image or invalid format or position
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: LogoError
        /// </param>
        /// <param name="description">
        /// Default Value: Could not load logo image or invalid format or position
        /// </param>
        public GetAnimationsResponseDtoAnimationErrorVariant2(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDtoAnimationErrorVariant2" /> class.
        /// </summary>
        public GetAnimationsResponseDtoAnimationErrorVariant2()
        {
        }
    }
}