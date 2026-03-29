//HintName: G.Models.PartialRequestResponseLogToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRequestResponseLogToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::G.PartialNumberOperators? Latency { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.PartialNumberOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_created_at")]
        public global::G.PartialTimestampOperatorsTyped? RequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_created_at")]
        public global::G.PartialTimestampOperatorsTyped? ResponseCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_hash")]
        public global::G.PartialTextOperators? AuthHash { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::G.PartialTextOperators? Model { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::G.PartialTextOperators? UserId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::G.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public global::G.PartialTextOperators? NodeId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public global::G.PartialTextOperators? JobId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threat")]
        public global::G.PartialBooleanOperators? Threat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseLogToOperators" /> class.
        /// </summary>
        /// <param name="latency">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="authHash">
        /// Make all properties in T optional
        /// </param>
        /// <param name="model">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="nodeId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="jobId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="threat">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRequestResponseLogToOperators(
            global::G.PartialNumberOperators? latency,
            global::G.PartialNumberOperators? status,
            global::G.PartialTimestampOperatorsTyped? requestCreatedAt,
            global::G.PartialTimestampOperatorsTyped? responseCreatedAt,
            global::G.PartialTextOperators? authHash,
            global::G.PartialTextOperators? model,
            global::G.PartialTextOperators? userId,
            global::G.PartialTextOperators? organizationId,
            global::G.PartialTextOperators? nodeId,
            global::G.PartialTextOperators? jobId,
            global::G.PartialBooleanOperators? threat)
        {
            this.Latency = latency;
            this.Status = status;
            this.RequestCreatedAt = requestCreatedAt;
            this.ResponseCreatedAt = responseCreatedAt;
            this.AuthHash = authHash;
            this.Model = model;
            this.UserId = userId;
            this.OrganizationId = organizationId;
            this.NodeId = nodeId;
            this.JobId = jobId;
            this.Threat = threat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseLogToOperators" /> class.
        /// </summary>
        public PartialRequestResponseLogToOperators()
        {
        }
    }
}