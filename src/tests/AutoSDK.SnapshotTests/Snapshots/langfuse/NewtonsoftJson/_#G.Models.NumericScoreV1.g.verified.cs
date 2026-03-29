//HintName: G.Models.NumericScoreV1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericScoreV1
    {
        /// <summary>
        /// The numeric value of the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScoreV1" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score
        /// </param>
        public NumericScoreV1(
            double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScoreV1" /> class.
        /// </summary>
        public NumericScoreV1()
        {
        }
    }
}