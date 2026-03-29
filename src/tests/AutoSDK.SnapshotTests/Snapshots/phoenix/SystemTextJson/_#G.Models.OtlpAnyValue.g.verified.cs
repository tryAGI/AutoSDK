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
        [global::System.Text.Json.Serialization.JsonPropertyName("array_value")]
        public global::G.OtlpArrayValue? ArrayValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bool_value")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes_value")]
        public string? BytesValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("double_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, global::G.OtlpDoubleValue?, string, object>))]
        public global::G.AnyOf<double?, global::G.OtlpDoubleValue?, string, object>? DoubleValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>))]
        public global::G.AnyOf<int?, string, object>? IntValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kvlist_value")]
        public object? KvlistValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_value")]
        public string? StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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