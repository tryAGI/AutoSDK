//HintName: G.Models.OtlpKeyValueValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attribute value. Exactly one of the value fields must be set.
    /// </summary>
    public sealed partial class OtlpKeyValueValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intValue")]
        public string? IntValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doubleValue")]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boolValue")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arrayValue")]
        public global::G.OtlpKeyValueValueArrayValue? ArrayValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValueValue" /> class.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="intValue"></param>
        /// <param name="doubleValue"></param>
        /// <param name="boolValue"></param>
        /// <param name="arrayValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpKeyValueValue(
            string? stringValue,
            string? intValue,
            double? doubleValue,
            bool? boolValue,
            global::G.OtlpKeyValueValueArrayValue? arrayValue)
        {
            this.StringValue = stringValue;
            this.IntValue = intValue;
            this.DoubleValue = doubleValue;
            this.BoolValue = boolValue;
            this.ArrayValue = arrayValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValueValue" /> class.
        /// </summary>
        public OtlpKeyValueValue()
        {
        }
    }
}