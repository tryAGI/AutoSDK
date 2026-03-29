//HintName: G.Models.DeleteAnimationResponseErrorVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAnimationResponseErrorVariant4
    {
        /// <summary>
        /// Default Value: FaceError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: face not detected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant4" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: FaceError
        /// </param>
        /// <param name="description">
        /// Default Value: face not detected
        /// </param>
        public DeleteAnimationResponseErrorVariant4(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant4" /> class.
        /// </summary>
        public DeleteAnimationResponseErrorVariant4()
        {
        }
    }
}