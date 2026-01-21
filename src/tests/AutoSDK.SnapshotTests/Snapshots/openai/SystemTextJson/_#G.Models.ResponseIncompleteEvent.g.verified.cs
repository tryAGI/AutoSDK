//HintName: G.Models.ResponseIncompleteEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An event that is emitted when a response finishes as incomplete.
    /// </summary>
    public sealed partial class ResponseIncompleteEvent
    {
        /// <summary>
        /// The type of the event. Always `response.incomplete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseIncompleteEventTypeJsonConverter))]
        public global::G.ResponseIncompleteEventType Type { get; set; }

        /// <summary>
        /// Example: {"id":"resp_67ccd3a9da748190baa7f1570fe91ac604becb25c45c1d41","object":"response","created_at":1741476777,"status":"completed","error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","incomplete_details":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","instructions":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","model":"gpt-4o-2024-08-06","output":[{"type":"message","id":"msg_67ccd3acc8d48190a77525dc6de64b4104becb25c45c1d41","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The image depicts a scenic landscape with a wooden boardwalk or pathway leading through lush, green grass under a blue sky with some clouds. The setting suggests a peaceful natural area, possibly a park or nature reserve. There are trees and shrubs in the background.","annotations":[]}]}],"parallel_tool_calls":true,"previous_response_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","reasoning":{"effort":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"store":true,"temperature":1,"text":{"format":{"type":"text"}},"tool_choice":"auto","tools":[],"top_p":1,"truncation":"disabled","usage":{"input_tokens":328,"input_tokens_details":{"cached_tokens":0},"output_tokens":52,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":380},"user":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metadata":{}}
        /// </summary>
        /// <example>{"id":"resp_67ccd3a9da748190baa7f1570fe91ac604becb25c45c1d41","object":"response","created_at":1741476777,"status":"completed","error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","incomplete_details":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","instructions":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","model":"gpt-4o-2024-08-06","output":[{"type":"message","id":"msg_67ccd3acc8d48190a77525dc6de64b4104becb25c45c1d41","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The image depicts a scenic landscape with a wooden boardwalk or pathway leading through lush, green grass under a blue sky with some clouds. The setting suggests a peaceful natural area, possibly a park or nature reserve. There are trees and shrubs in the background.","annotations":[]}]}],"parallel_tool_calls":true,"previous_response_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","reasoning":{"effort":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"store":true,"temperature":1,"text":{"format":{"type":"text"}},"tool_choice":"auto","tools":[],"top_p":1,"truncation":"disabled","usage":{"input_tokens":328,"input_tokens_details":{"cached_tokens":0},"output_tokens":52,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":380},"user":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metadata":{}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Response Response { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.incomplete`.
        /// </param>
        /// <param name="response">
        /// Example: {"id":"resp_67ccd3a9da748190baa7f1570fe91ac604becb25c45c1d41","object":"response","created_at":1741476777,"status":"completed","error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","incomplete_details":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","instructions":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","model":"gpt-4o-2024-08-06","output":[{"type":"message","id":"msg_67ccd3acc8d48190a77525dc6de64b4104becb25c45c1d41","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The image depicts a scenic landscape with a wooden boardwalk or pathway leading through lush, green grass under a blue sky with some clouds. The setting suggests a peaceful natural area, possibly a park or nature reserve. There are trees and shrubs in the background.","annotations":[]}]}],"parallel_tool_calls":true,"previous_response_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","reasoning":{"effort":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"store":true,"temperature":1,"text":{"format":{"type":"text"}},"tool_choice":"auto","tools":[],"top_p":1,"truncation":"disabled","usage":{"input_tokens":328,"input_tokens_details":{"cached_tokens":0},"output_tokens":52,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":380},"user":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metadata":{}}
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseIncompleteEvent(
            global::G.Response response,
            int sequenceNumber,
            global::G.ResponseIncompleteEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        public ResponseIncompleteEvent()
        {
        }
    }
}