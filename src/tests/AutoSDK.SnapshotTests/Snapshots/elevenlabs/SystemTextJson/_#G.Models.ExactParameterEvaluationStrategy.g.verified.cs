//HintName: G.Models.ExactParameterEvaluationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExactParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"exact"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "exact";

        /// <summary>
        /// The exact string value that the parameter must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpectedValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="expectedValue">
        /// The exact string value that the parameter must match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExactParameterEvaluationStrategy(
            string expectedValue,
            string type = "exact")
        {
            this.ExpectedValue = expectedValue ?? throw new global::System.ArgumentNullException(nameof(expectedValue));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactParameterEvaluationStrategy" /> class.
        /// </summary>
        public ExactParameterEvaluationStrategy()
        {
        }
    }
}