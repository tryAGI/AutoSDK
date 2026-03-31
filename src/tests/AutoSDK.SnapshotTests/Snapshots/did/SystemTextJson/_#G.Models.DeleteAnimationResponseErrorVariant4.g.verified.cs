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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: face not detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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