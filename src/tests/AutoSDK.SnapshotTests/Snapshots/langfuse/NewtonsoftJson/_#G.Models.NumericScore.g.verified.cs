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
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScore" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score
        /// </param>
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