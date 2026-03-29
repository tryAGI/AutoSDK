//HintName: G.Models.CategoricalScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalScore
    {
        /// <summary>
        /// Represents the numeric category mapping of the stringValue. If no config is linked, defaults to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// The string representation of the score value. If no config is linked, can be any string. Otherwise, must map to a config category
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalScore" /> class.
        /// </summary>
        /// <param name="value">
        /// Represents the numeric category mapping of the stringValue. If no config is linked, defaults to 0.
        /// </param>
        /// <param name="stringValue">
        /// The string representation of the score value. If no config is linked, can be any string. Otherwise, must map to a config category
        /// </param>
        public CategoricalScore(
            double value,
            string stringValue)
        {
            this.Value = value;
            this.StringValue = stringValue ?? throw new global::System.ArgumentNullException(nameof(stringValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalScore" /> class.
        /// </summary>
        public CategoricalScore()
        {
        }
    }
}