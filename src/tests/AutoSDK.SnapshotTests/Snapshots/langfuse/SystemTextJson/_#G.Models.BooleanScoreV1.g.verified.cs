//HintName: G.Models.BooleanScoreV1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanScoreV1
    {
        /// <summary>
        /// The numeric value of the score. Equals 1 for "True" and 0 for "False"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// The string representation of the score value. Is inferred from the numeric value and equals "True" or "False"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScoreV1" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score. Equals 1 for "True" and 0 for "False"
        /// </param>
        /// <param name="stringValue">
        /// The string representation of the score value. Is inferred from the numeric value and equals "True" or "False"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BooleanScoreV1(
            double value,
            string stringValue)
        {
            this.Value = value;
            this.StringValue = stringValue ?? throw new global::System.ArgumentNullException(nameof(stringValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScoreV1" /> class.
        /// </summary>
        public BooleanScoreV1()
        {
        }
    }
}