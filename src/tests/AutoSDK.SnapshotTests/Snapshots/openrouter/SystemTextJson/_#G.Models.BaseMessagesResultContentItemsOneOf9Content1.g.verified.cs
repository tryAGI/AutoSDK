//HintName: G.Models.BaseMessagesResultContentItemsOneOf9Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf9Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public double? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public double? StartLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines")]
        public double? TotalLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fileType"></param>
        /// <param name="numLines"></param>
        /// <param name="startLine"></param>
        /// <param name="totalLines"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf9Content1(
            string content,
            global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType fileType,
            double? numLines,
            double? startLine,
            double? totalLines,
            global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf1Type type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FileType = fileType;
            this.NumLines = numLines;
            this.StartLine = startLine;
            this.TotalLines = totalLines;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf9Content1()
        {
        }
    }
}