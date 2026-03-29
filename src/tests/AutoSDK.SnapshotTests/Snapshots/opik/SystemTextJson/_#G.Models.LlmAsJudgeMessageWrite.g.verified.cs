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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LlmAsJudgeMessageWriteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LlmAsJudgeMessageWriteRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_array")]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessageContentWrite>? ContentArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_content")]
        public bool? StringContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_content")]
        public bool? StructuredContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageWrite" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="contentArray"></param>
        /// <param name="stringContent"></param>
        /// <param name="structuredContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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