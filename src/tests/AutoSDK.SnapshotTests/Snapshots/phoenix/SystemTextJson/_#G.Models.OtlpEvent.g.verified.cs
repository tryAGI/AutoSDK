//HintName: G.Models.OtlpEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpEvent
    {
        /// <summary>
        /// attributes is a collection of attribute key/value pairs on the event. Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// dropped_attributes_count is the number of dropped attributes. If the value is 0, then no attributes were dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropped_attributes_count")]
        public int? DroppedAttributesCount { get; set; }

        /// <summary>
        /// name of the event. This field is semantically required to be set to non-empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// time_unix_nano is the time the event occurred. Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_unix_nano")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>))]
        public global::G.AnyOf<long?, string, object>? TimeUnixNano { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpEvent" /> class.
        /// </summary>
        /// <param name="attributes">
        /// attributes is a collection of attribute key/value pairs on the event. Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
        /// </param>
        /// <param name="droppedAttributesCount">
        /// dropped_attributes_count is the number of dropped attributes. If the value is 0, then no attributes were dropped.
        /// </param>
        /// <param name="name">
        /// name of the event. This field is semantically required to be set to non-empty string.
        /// </param>
        /// <param name="timeUnixNano">
        /// time_unix_nano is the time the event occurred. Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpEvent(
            global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? attributes,
            int? droppedAttributesCount,
            string? name,
            global::G.AnyOf<long?, string, object>? timeUnixNano)
        {
            this.Attributes = attributes;
            this.DroppedAttributesCount = droppedAttributesCount;
            this.Name = name;
            this.TimeUnixNano = timeUnixNano;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpEvent" /> class.
        /// </summary>
        public OtlpEvent()
        {
        }
    }
}