//HintName: G.Models.GetAnimationResponseErrorVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationResponseErrorVariant3
    {
        /// <summary>
        /// Default Value: SourceError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Could not load source image or invalid format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationResponseErrorVariant3" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: SourceError
        /// </param>
        /// <param name="description">
        /// Default Value: Could not load source image or invalid format
        /// </param>
        public GetAnimationResponseErrorVariant3(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationResponseErrorVariant3" /> class.
        /// </summary>
        public GetAnimationResponseErrorVariant3()
        {
        }
    }
}