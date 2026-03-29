//HintName: G.Models.Message.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_event_id")]
        public string? EndingEventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_event_id")]
        public string? TriggerEventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public string? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::G.MessageAnnotation>? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentArray")]
        public global::System.Collections.Generic.IList<global::G.Message>? ContentArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idx")]
        public double? Idx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageTypeJsonConverter))]
        public global::G.MessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_data")]
        public string? AudioData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.FunctionCall2>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.MessageRole?>))]
        public global::G.AnyOf<string, global::G.MessageRole?>? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageType2 Type2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="type2"></param>
        /// <param name="endingEventId"></param>
        /// <param name="triggerEventId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="annotations"></param>
        /// <param name="reasoning"></param>
        /// <param name="deleted"></param>
        /// <param name="contentArray"></param>
        /// <param name="idx"></param>
        /// <param name="detail"></param>
        /// <param name="filename"></param>
        /// <param name="fileId"></param>
        /// <param name="fileData"></param>
        /// <param name="type"></param>
        /// <param name="audioData"></param>
        /// <param name="imageUrl"></param>
        /// <param name="timestamp"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolCalls"></param>
        /// <param name="mimeType"></param>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="instruction"></param>
        /// <param name="role"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            global::G.MessageType2 type2,
            string? endingEventId,
            string? triggerEventId,
            string? startTimestamp,
            global::System.Collections.Generic.IList<global::G.MessageAnnotation>? annotations,
            string? reasoning,
            bool? deleted,
            global::System.Collections.Generic.IList<global::G.Message>? contentArray,
            double? idx,
            string? detail,
            string? filename,
            string? fileId,
            string? fileData,
            global::G.MessageType? type,
            string? audioData,
            string? imageUrl,
            string? timestamp,
            string? toolCallId,
            global::System.Collections.Generic.IList<global::G.FunctionCall2>? toolCalls,
            string? mimeType,
            string? content,
            string? name,
            string? instruction,
            global::G.AnyOf<string, global::G.MessageRole?>? role,
            string? id)
        {
            this.EndingEventId = endingEventId;
            this.TriggerEventId = triggerEventId;
            this.StartTimestamp = startTimestamp;
            this.Annotations = annotations;
            this.Reasoning = reasoning;
            this.Deleted = deleted;
            this.ContentArray = contentArray;
            this.Idx = idx;
            this.Detail = detail;
            this.Filename = filename;
            this.FileId = fileId;
            this.FileData = fileData;
            this.Type = type;
            this.AudioData = audioData;
            this.ImageUrl = imageUrl;
            this.Timestamp = timestamp;
            this.ToolCallId = toolCallId;
            this.ToolCalls = toolCalls;
            this.MimeType = mimeType;
            this.Content = content;
            this.Name = name;
            this.Instruction = instruction;
            this.Role = role;
            this.Id = id;
            this.Type2 = type2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }
    }
}