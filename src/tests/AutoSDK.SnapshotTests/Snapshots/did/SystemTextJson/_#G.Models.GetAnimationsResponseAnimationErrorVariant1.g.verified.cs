//HintName: G.Models.GetAnimationsResponseAnimationErrorVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseAnimationErrorVariant1
    {
        /// <summary>
        /// Default Value: DriverError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Driver provided is invalid or cannot be loaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseAnimationErrorVariant1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: DriverError
        /// </param>
        /// <param name="description">
        /// Default Value: Driver provided is invalid or cannot be loaded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationsResponseAnimationErrorVariant1(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseAnimationErrorVariant1" /> class.
        /// </summary>
        public GetAnimationsResponseAnimationErrorVariant1()
        {
        }
    }
}