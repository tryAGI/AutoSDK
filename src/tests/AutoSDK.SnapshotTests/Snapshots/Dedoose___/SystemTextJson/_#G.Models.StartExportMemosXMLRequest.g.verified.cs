//HintName: G.Models.StartExportMemosXMLRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportMemosXMLRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> MemoIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CodeSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MediaSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptsSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExcerptsSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorsSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DescriptorsSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SymKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportMemosXMLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="codeSelection"></param>
        /// <param name="mediaSelection"></param>
        /// <param name="excerptsSelection"></param>
        /// <param name="descriptorsSelection"></param>
        /// <param name="symKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartExportMemosXMLRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            int codeSelection,
            int mediaSelection,
            int excerptsSelection,
            int descriptorsSelection,
            string symKey)
        {
            this.ProjectId = projectId;
            this.MemoIds = memoIds ?? throw new global::System.ArgumentNullException(nameof(memoIds));
            this.CodeSelection = codeSelection;
            this.MediaSelection = mediaSelection;
            this.ExcerptsSelection = excerptsSelection;
            this.DescriptorsSelection = descriptorsSelection;
            this.SymKey = symKey ?? throw new global::System.ArgumentNullException(nameof(symKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportMemosXMLRequest" /> class.
        /// </summary>
        public StartExportMemosXMLRequest()
        {
        }
    }
}