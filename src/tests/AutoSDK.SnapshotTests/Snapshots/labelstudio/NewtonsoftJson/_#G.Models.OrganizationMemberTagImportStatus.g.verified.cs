//HintName: G.Models.OrganizationMemberTagImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for the status of a member tag import job.
    /// </summary>
    public sealed partial class OrganizationMemberTagImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignments_created")]
        public int? AssignmentsCreated { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In Progress<br/>
        /// * `completed` - Completed<br/>
        /// * `failed` - Failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.OrganizationMemberTagImportStatusStatusEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_created")]
        public int? TagsCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users_skipped")]
        public object? UsersSkipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagImportStatus" /> class.
        /// </summary>
        /// <param name="assignmentsCreated"></param>
        /// <param name="finishedAt"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In Progress<br/>
        /// * `completed` - Completed<br/>
        /// * `failed` - Failed
        /// </param>
        /// <param name="tagsCreated"></param>
        /// <param name="usersSkipped"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public OrganizationMemberTagImportStatus(
            int? assignmentsCreated,
            global::System.DateTime? finishedAt,
            global::G.OrganizationMemberTagImportStatusStatusEnum? status,
            int? tagsCreated,
            object? usersSkipped,
            global::System.DateTime createdAt = default!,
            int id = default!)
        {
            this.AssignmentsCreated = assignmentsCreated;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
            this.Id = id;
            this.Status = status;
            this.TagsCreated = tagsCreated;
            this.UsersSkipped = usersSkipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagImportStatus" /> class.
        /// </summary>
        public OrganizationMemberTagImportStatus()
        {
        }
    }
}