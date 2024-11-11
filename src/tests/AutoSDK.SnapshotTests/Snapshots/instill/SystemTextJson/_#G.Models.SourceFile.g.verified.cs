//HintName: G.Models.SourceFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SourceFile message represents a source file in the artifact system.
    /// </summary>
    public sealed partial class SourceFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalFileUid")]
        public string? OriginalFileUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFile" /> class.
        /// </summary>
        /// <param name="originalFileUid"></param>
        /// <param name="content"></param>
        /// <param name="createTime"></param>
        /// <param name="updateTime"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SourceFile(
            string? originalFileUid,
            string? content,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.OriginalFileUid = originalFileUid;
            this.Content = content;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFile" /> class.
        /// </summary>
        public SourceFile()
        {
        }
    }
}