//HintName: G.Models.StartExcerptsExportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExcerptsExportRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExcerptExportOptions Options { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("symKeyEncrypted", Required = global::Newtonsoft.Json.Required.Always)]
        public string SymKeyEncrypted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExcerptsExportRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="options"></param>
        /// <param name="symKeyEncrypted"></param>
        public StartExcerptsExportRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds,
            global::G.ExcerptExportOptions options,
            string symKeyEncrypted)
        {
            this.ProjectId = projectId;
            this.ExcerptIds = excerptIds ?? throw new global::System.ArgumentNullException(nameof(excerptIds));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.SymKeyEncrypted = symKeyEncrypted ?? throw new global::System.ArgumentNullException(nameof(symKeyEncrypted));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExcerptsExportRequest" /> class.
        /// </summary>
        public StartExcerptsExportRequest()
        {
        }
    }
}