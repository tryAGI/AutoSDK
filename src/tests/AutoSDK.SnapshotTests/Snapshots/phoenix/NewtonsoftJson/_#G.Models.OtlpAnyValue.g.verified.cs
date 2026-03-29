//HintName: G.Models.OtlpAnyValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpAnyValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("array_value")]
        public global::G.OtlpArrayValue? ArrayValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bool_value")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes_value")]
        public string? BytesValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("double_value")]
        public global::G.AnyOf<double?, global::G.OtlpDoubleValue?, string, object>? DoubleValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("int_value")]
        public global::G.AnyOf<int?, string, object>? IntValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kvlist_value")]
        public object? KvlistValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string_value")]
        public string? StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpAnyValue" /> class.
        /// </summary>
        /// <param name="arrayValue"></param>
        /// <param name="boolValue"></param>
        /// <param name="bytesValue"></param>
        /// <param name="doubleValue"></param>
        /// <param name="intValue"></param>
        /// <param name="kvlistValue"></param>
        /// <param name="stringValue"></param>
        public OtlpAnyValue(
            global::G.OtlpArrayValue? arrayValue,
            bool? boolValue,
            string? bytesValue,
            global::G.AnyOf<double?, global::G.OtlpDoubleValue?, string, object>? doubleValue,
            global::G.AnyOf<int?, string, object>? intValue,
            object? kvlistValue,
            string? stringValue)
        {
            this.ArrayValue = arrayValue;
            this.BoolValue = boolValue;
            this.BytesValue = bytesValue;
            this.DoubleValue = doubleValue;
            this.IntValue = intValue;
            this.KvlistValue = kvlistValue;
            this.StringValue = stringValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpAnyValue" /> class.
        /// </summary>
        public OtlpAnyValue()
        {
        }
    }
}