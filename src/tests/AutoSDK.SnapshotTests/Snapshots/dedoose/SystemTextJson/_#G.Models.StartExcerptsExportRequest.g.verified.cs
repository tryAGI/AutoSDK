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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExcerptExportOptions Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symKeyEncrypted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SymKeyEncrypted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExcerptsExportRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="options"></param>
        /// <param name="symKeyEncrypted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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