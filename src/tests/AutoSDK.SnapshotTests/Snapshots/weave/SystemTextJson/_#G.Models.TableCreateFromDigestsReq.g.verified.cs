//HintName: G.Models.TableCreateFromDigestsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCreateFromDigestsReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RowDigests { get; set; }

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
        /// Initializes a new instance of the <see cref="TableCreateFromDigestsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="expectedDigest">
        /// Client-computed table digest for server-side validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableCreateFromDigestsReq(
            string projectId,
            global::System.Collections.Generic.IList<string> rowDigests,
            string? expectedDigest)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.RowDigests = rowDigests ?? throw new global::System.ArgumentNullException(nameof(rowDigests));
            this.ExpectedDigest = expectedDigest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateFromDigestsReq" /> class.
        /// </summary>
        public TableCreateFromDigestsReq()
        {
        }
    }
}