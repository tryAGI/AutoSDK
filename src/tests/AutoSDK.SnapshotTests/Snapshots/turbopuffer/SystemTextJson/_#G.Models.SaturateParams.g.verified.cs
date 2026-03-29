//HintName: G.Models.SaturateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional parameters for the Saturate operator.
    /// </summary>
    public sealed partial class SaturateParams
    {
        /// <summary>
        /// The midpoint of the Saturate operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("midpoint")]
        public object? Midpoint { get; set; }

        /// <summary>
        /// An exponent that helps further control the shape of the Saturate function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exponent")]
        public double? Exponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaturateParams" /> class.
        /// </summary>
        /// <param name="midpoint">
        /// The midpoint of the Saturate operator.
        /// </param>
        /// <param name="exponent">
        /// An exponent that helps further control the shape of the Saturate function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaturateParams(
            object? midpoint,
            double? exponent)
        {
            this.Midpoint = midpoint;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaturateParams" /> class.
        /// </summary>
        public SaturateParams()
        {
        }
    }
}