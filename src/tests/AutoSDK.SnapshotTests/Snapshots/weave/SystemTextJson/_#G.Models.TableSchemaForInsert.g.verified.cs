//HintName: G.Models.TableSchemaForInsert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSchemaForInsert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Rows { get; set; }

        /// <summary>
        /// Client-computed table digest for server-side validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_digest")]
        public string? ExpectedDigest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSchemaForInsert" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rows"></param>
        /// <param name="expectedDigest">
        /// Client-computed table digest for server-side validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSchemaForInsert(
            string projectId,
            global::System.Collections.Generic.IList<object> rows,
            string? expectedDigest)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.ExpectedDigest = expectedDigest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSchemaForInsert" /> class.
        /// </summary>
        public TableSchemaForInsert()
        {
        }
    }
}