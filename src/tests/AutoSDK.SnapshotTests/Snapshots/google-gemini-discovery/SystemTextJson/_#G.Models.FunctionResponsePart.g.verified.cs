//HintName: G.Models.FunctionResponsePart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A datatype containing media that is part of a `FunctionResponse` message. A `FunctionResponsePart` consists of data which has an associated datatype. A `FunctionResponsePart` can only contain one of the accepted types in `FunctionResponsePart.data`. A `FunctionResponsePart` must have a fixed IANA MIME type identifying the type and subtype of the media if the `inline_data` field is filled with raw bytes.
    /// </summary>
    public sealed partial class FunctionResponsePart
    {
        /// <summary>
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlineData")]
        public global::G.FunctionResponseBlob? InlineData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        /// <param name="inlineData">
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponsePart(
            global::G.FunctionResponseBlob? inlineData)
        {
            this.InlineData = inlineData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        public FunctionResponsePart()
        {
        }
    }
}