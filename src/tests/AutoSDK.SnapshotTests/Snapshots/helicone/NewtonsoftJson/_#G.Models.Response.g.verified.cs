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
        [global::Newtonsoft.Json.JsonProperty("contentArray")]
        public global::System.Collections.Generic.IList<global::G.Response>? ContentArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idx")]
        public double? Idx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_data")]
        public string? AudioData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.FunctionCall2>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseTypeJsonConverter))]
        public global::G.ResponseType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseRoleJsonConverter))]
        public global::G.ResponseRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseType2JsonConverter))]
        public global::G.ResponseType2 Type2 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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