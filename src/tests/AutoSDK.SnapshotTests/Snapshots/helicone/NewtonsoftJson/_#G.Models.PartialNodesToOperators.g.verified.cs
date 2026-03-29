//HintName: G.Models.PartialNodesToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialNodesToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.PartialTextOperators? Name { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.PartialTextOperators? Description { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public global::G.PartialTextOperators? JobId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PartialTextOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::G.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::G.PartialTimestampOperators? UpdatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_seconds")]
        public global::G.PartialNumberOperators? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? CustomProperties { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public global::G.PartialTextOperators? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialNodesToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="name">
        /// Make all properties in T optional
        /// </param>
        /// <param name="description">
        /// Make all properties in T optional
        /// </param>
        /// <param name="jobId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="updatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="timeoutSeconds">
        /// Make all properties in T optional
        /// </param>
        /// <param name="customProperties"></param>
        /// <param name="orgId">
        /// Make all properties in T optional
        /// </param>
        public PartialNodesToOperators(
            global::G.PartialTextOperators? id,
            global::G.PartialTextOperators? name,
            global::G.PartialTextOperators? description,
            global::G.PartialTextOperators? jobId,
            global::G.PartialTextOperators? status,
            global::G.PartialTimestampOperators? createdAt,
            global::G.PartialTimestampOperators? updatedAt,
            global::G.PartialNumberOperators? timeoutSeconds,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? customProperties,
            global::G.PartialTextOperators? orgId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.JobId = jobId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TimeoutSeconds = timeoutSeconds;
            this.CustomProperties = customProperties;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialNodesToOperators" /> class.
        /// </summary>
        public PartialNodesToOperators()
        {
        }
    }
}