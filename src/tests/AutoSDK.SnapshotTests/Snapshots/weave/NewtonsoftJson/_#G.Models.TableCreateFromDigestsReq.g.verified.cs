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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_digests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RowDigests { get; set; } = default!;

        /// <summary>
        /// Client-computed table digest for server-side validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_digest")]
        public string? ExpectedDigest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateFromDigestsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="expectedDigest">
        /// Client-computed table digest for server-side validation.
        /// </param>
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