//HintName: G.Models.NumericScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericScore
    {
        /// <summary>
        /// The numeric value of the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScore" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericScore(
            double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScore" /> class.
        /// </summary>
        public NumericScore()
        {
        }
    }
}