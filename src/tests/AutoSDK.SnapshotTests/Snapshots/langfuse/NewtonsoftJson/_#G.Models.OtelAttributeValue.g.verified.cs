//HintName: G.Models.OtelAttributeValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Attribute value wrapper supporting different value types
    /// </summary>
    public sealed partial class OtelAttributeValue
    {
        /// <summary>
        /// String value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// Integer value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intValue")]
        public int? IntValue { get; set; }

        /// <summary>
        /// Double value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("doubleValue")]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Boolean value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("boolValue")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelAttributeValue" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// String value
        /// </param>
        /// <param name="intValue">
        /// Integer value
        /// </param>
        /// <param name="doubleValue">
        /// Double value
        /// </param>
        /// <param name="boolValue">
        /// Boolean value
        /// </param>
        public OtelAttributeValue(
            string? stringValue,
            int? intValue,
            double? doubleValue,
            bool? boolValue)
        {
            this.StringValue = stringValue;
            this.IntValue = intValue;
            this.DoubleValue = doubleValue;
            this.BoolValue = boolValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelAttributeValue" /> class.
        /// </summary>
        public OtelAttributeValue()
        {
        }
    }
}