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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> MemoIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension", Required = global::Newtonsoft.Json.Required.Always)]
        public string Extension { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeCodes", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeCodes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeMedia", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeMedia { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeExcerpts", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeExcerpts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeDescriptors", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeDescriptors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("symKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SymKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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