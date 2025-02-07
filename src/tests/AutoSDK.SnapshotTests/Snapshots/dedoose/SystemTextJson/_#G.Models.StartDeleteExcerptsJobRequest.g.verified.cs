//HintName: G.Models.StartDeleteExcerptsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDeleteExcerptsJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CurrentProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteExcerptsJobRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartDeleteExcerptsJobRequest(
            global::System.Guid currentProjectId,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds)
        {
            this.CurrentProjectId = currentProjectId;
            this.ExcerptIds = excerptIds ?? throw new global::System.ArgumentNullException(nameof(excerptIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteExcerptsJobRequest" /> class.
        /// </summary>
        public StartDeleteExcerptsJobRequest()
        {
        }
    }
}