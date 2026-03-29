//HintName: G.Models.ScoreV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ValueType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<double?, global::System.DateTime?, string> Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max", Required = global::Newtonsoft.Json.Required.Always)]
        public double Max { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min", Required = global::Newtonsoft.Json.Required.Always)]
        public double Min { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreV2" /> class.
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public ScoreV2(
            string valueType,
            global::G.AnyOf<double?, global::System.DateTime?, string> value,
            double max,
            double min)
        {
            this.ValueType = valueType ?? throw new global::System.ArgumentNullException(nameof(valueType));
            this.Value = value;
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreV2" /> class.
        /// </summary>
        public ScoreV2()
        {
        }
    }
}