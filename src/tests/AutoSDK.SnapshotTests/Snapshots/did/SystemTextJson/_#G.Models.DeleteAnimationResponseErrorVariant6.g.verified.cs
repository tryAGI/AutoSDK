//HintName: G.Models.DeleteAnimationResponseErrorVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAnimationResponseErrorVariant6
    {
        /// <summary>
        /// Default Value: UnknownError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Unknown internal error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant6" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: UnknownError
        /// </param>
        /// <param name="description">
        /// Default Value: Unknown internal error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAnimationResponseErrorVariant6(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant6" /> class.
        /// </summary>
        public DeleteAnimationResponseErrorVariant6()
        {
        }
    }
}