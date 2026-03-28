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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "exact";

        /// <summary>
        /// The exact string value that the parameter must match.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpectedValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="expectedValue">
        /// The exact string value that the parameter must match.
        /// </param>
        /// <param name="type"></param>
        public ExactParameterEvaluationStrategy(
            string expectedValue,
            string type = "exact")
        {
            this.Type = type;
            this.ExpectedValue = expectedValue ?? throw new global::System.ArgumentNullException(nameof(expectedValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactParameterEvaluationStrategy" /> class.
        /// </summary>
        public ExactParameterEvaluationStrategy()
        {
        }
    }
}