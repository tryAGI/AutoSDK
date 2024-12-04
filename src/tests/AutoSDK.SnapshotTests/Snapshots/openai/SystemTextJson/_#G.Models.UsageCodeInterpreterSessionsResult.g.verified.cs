//HintName: G.Models.UsageCodeInterpreterSessionsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated code interpreter sessions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageCodeInterpreterSessionsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageCodeInterpreterSessionsResultObjectJsonConverter))]
        public global::G.UsageCodeInterpreterSessionsResultObject Object { get; set; }

        /// <summary>
        /// The number of code interpreter sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sessions { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="sessions">
        /// The number of code interpreter sessions.
        /// </param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsageCodeInterpreterSessionsResult(
            int sessions,
            global::G.UsageCodeInterpreterSessionsResultObject @object,
            string? projectId)
        {
            this.Sessions = sessions;
            this.Object = @object;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        public UsageCodeInterpreterSessionsResult()
        {
        }
    }
}