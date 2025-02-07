//HintName: G.Models.StartExportMemosRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportMemosRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeCodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeMedia")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeMedia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeExcerpts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeExcerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDescriptors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeDescriptors { get; set; }

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
        /// Initializes a new instance of the <see cref="StartExportMemosRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="description"></param>
        /// <param name="extension"></param>
        /// <param name="includeCodes"></param>
        /// <param name="includeMedia"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="includeDescriptors"></param>
        /// <param name="symKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartExportMemosRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            string description,
            string extension,
            bool includeCodes,
            bool includeMedia,
            bool includeExcerpts,
            bool includeDescriptors,
            string symKey)
        {
            this.ProjectId = projectId;
            this.MemoIds = memoIds ?? throw new global::System.ArgumentNullException(nameof(memoIds));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
            this.IncludeCodes = includeCodes;
            this.IncludeMedia = includeMedia;
            this.IncludeExcerpts = includeExcerpts;
            this.IncludeDescriptors = includeDescriptors;
            this.SymKey = symKey ?? throw new global::System.ArgumentNullException(nameof(symKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportMemosRequest" /> class.
        /// </summary>
        public StartExportMemosRequest()
        {
        }
    }
}