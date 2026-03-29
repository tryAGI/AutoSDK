//HintName: G.Models.LlmAsJudgeMessageWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeMessageWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LlmAsJudgeMessageWriteRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_array")]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessageContentWrite>? ContentArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string_content")]
        public bool? StringContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structured_content")]
        public bool? StructuredContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageWrite" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="contentArray"></param>
        /// <param name="stringContent"></param>
        /// <param name="structuredContent"></param>
        public LlmAsJudgeMessageWrite(
            global::G.LlmAsJudgeMessageWriteRole role,
            string? content,
            global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessageContentWrite>? contentArray,
            bool? stringContent,
            bool? structuredContent)
        {
            this.Role = role;
            this.Content = content;
            this.ContentArray = contentArray;
            this.StringContent = stringContent;
            this.StructuredContent = structuredContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageWrite" /> class.
        /// </summary>
        public LlmAsJudgeMessageWrite()
        {
        }
    }
}