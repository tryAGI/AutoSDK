//HintName: G.Models.Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentArray")]
        public global::System.Collections.Generic.IList<global::G.Response>? ContentArray { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("idx")]
        public double? Idx { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseType2 Type2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="role"></param>
        /// <param name="type2"></param>
        /// <param name="contentArray"></param>
        /// <param name="detail"></param>
        /// <param name="filename"></param>
        /// <param name="fileId"></param>
        /// <param name="fileData"></param>
        /// <param name="idx"></param>
        /// <param name="audioData"></param>
        /// <param name="imageUrl"></param>
        /// <param name="timestamp"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolCalls"></param>
        /// <param name="text"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response(
            global::G.ResponseType type,
            global::G.ResponseRole role,
            global::G.ResponseType2 type2,
            global::System.Collections.Generic.IList<global::G.Response>? contentArray,
            string? detail,
            string? filename,
            string? fileId,
            string? fileData,
            double? idx,
            string? audioData,
            string? imageUrl,
            string? timestamp,
            string? toolCallId,
            global::System.Collections.Generic.IList<global::G.FunctionCall2>? toolCalls,
            string? text,
            string? name,
            string? id)
        {
            this.ContentArray = contentArray;
            this.Detail = detail;
            this.Filename = filename;
            this.FileId = fileId;
            this.FileData = fileData;
            this.Idx = idx;
            this.AudioData = audioData;
            this.ImageUrl = imageUrl;
            this.Timestamp = timestamp;
            this.ToolCallId = toolCallId;
            this.ToolCalls = toolCalls;
            this.Text = text;
            this.Type = type;
            this.Name = name;
            this.Role = role;
            this.Id = id;
            this.Type2 = type2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        public Response()
        {
        }
    }
}