//HintName: G.Models.EvalJsonlFileContentSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalJsonlFileContentSource
    {
        /// <summary>
        /// The type of jsonl source. Always `file_content`.<br/>
        /// Default Value: file_content
        /// </summary>
        /// <default>global::G.EvalJsonlFileContentSourceType.FileContent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalJsonlFileContentSourceTypeJsonConverter))]
        public global::G.EvalJsonlFileContentSourceType Type { get; set; } = global::G.EvalJsonlFileContentSourceType.FileContent;

        /// <summary>
        /// The content of the jsonl file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalJsonlFileContentSourceContentItem> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of jsonl source. Always `file_content`.<br/>
        /// Default Value: file_content
        /// </param>
        /// <param name="content">
        /// The content of the jsonl file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalJsonlFileContentSource(
            global::System.Collections.Generic.IList<global::G.EvalJsonlFileContentSourceContentItem> content,
            global::G.EvalJsonlFileContentSourceType type = global::G.EvalJsonlFileContentSourceType.FileContent)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSource" /> class.
        /// </summary>
        public EvalJsonlFileContentSource()
        {
        }
    }
}