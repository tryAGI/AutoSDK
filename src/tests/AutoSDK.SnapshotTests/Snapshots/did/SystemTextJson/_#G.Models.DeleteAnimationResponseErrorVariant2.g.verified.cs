//HintName: G.Models.DeleteAnimationResponseErrorVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAnimationResponseErrorVariant2
    {
        /// <summary>
        /// Default Value: LogoError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Could not load logo image or invalid format or position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: LogoError
        /// </param>
        /// <param name="description">
        /// Default Value: Could not load logo image or invalid format or position
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAnimationResponseErrorVariant2(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant2" /> class.
        /// </summary>
        public DeleteAnimationResponseErrorVariant2()
        {
        }
    }
}