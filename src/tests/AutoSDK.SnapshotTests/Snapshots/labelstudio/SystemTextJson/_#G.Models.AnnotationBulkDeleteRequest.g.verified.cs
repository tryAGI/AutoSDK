//HintName: G.Models.AnnotationBulkDeleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for bulk annotation deletion by IDs.
    /// </summary>
    public sealed partial class AnnotationBulkDeleteRequest
    {
        /// <summary>
        /// List of annotation IDs to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationBulkDeleteRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// List of annotation IDs to delete
        /// </param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationBulkDeleteRequest(
            global::System.Collections.Generic.IList<int> ids,
            int project)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationBulkDeleteRequest" /> class.
        /// </summary>
        public AnnotationBulkDeleteRequest()
        {
        }
    }
}