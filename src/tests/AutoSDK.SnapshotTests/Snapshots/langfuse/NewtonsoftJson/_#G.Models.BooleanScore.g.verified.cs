//HintName: G.Models.BooleanScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanScore
    {
        /// <summary>
        /// The numeric value of the score. Equals 1 for "True" and 0 for "False"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// The string representation of the score value. Is inferred from the numeric value and equals "True" or "False"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScore" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score. Equals 1 for "True" and 0 for "False"
        /// </param>
        /// <param name="stringValue">
        /// The string representation of the score value. Is inferred from the numeric value and equals "True" or "False"
        /// </param>
        public BooleanScore(
            double value,
            string stringValue)
        {
            this.Value = value;
            this.StringValue = stringValue ?? throw new global::System.ArgumentNullException(nameof(stringValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScore" /> class.
        /// </summary>
        public BooleanScore()
        {
        }
    }
}