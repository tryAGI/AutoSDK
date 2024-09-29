//HintName: G.Models.Part.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A datatype containing media that is part of a multi-part `Content` message. A `Part` consists of data which has an associated datatype. A `Part` can only contain one of the accepted types in `Part.data`. A `Part` must have a fixed IANA MIME type identifying the type and subtype of the media if the `inline_data` field is filled with raw bytes.
    /// </summary>
    public sealed partial class Part
    {
        /// <summary>
        /// Raw media bytes. Text should not be sent as raw bytes, use the 'text' field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlineData")]
        public global::G.Blob? InlineData { get; set; }

        /// <summary>
        /// Inline text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}