//HintName: G.Models.TaskAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TaskAssignment Serializer with FSM state support.<br/>
    /// Note: The 'state' field will be populated from the queryset annotation<br/>
    /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
    /// The state field display is controlled by both:<br/>
    /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
    /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
    /// </summary>
    public sealed partial class TaskAssignment
    {
        /// <summary>
        /// Assigned user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public int Assignee { get; set; } = default!;

        /// <summary>
        /// Time of assignment<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Assigned task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public int Task { get; set; } = default!;

        /// <summary>
        /// Type of assignment: Annotate|Review<br/>
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TypeEnumJsonConverter))]
        public global::G.TypeEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAssignment" /> class.
        /// </summary>
        /// <param name="assignee">
        /// Assigned user
        /// </param>
        /// <param name="task">
        /// Assigned task
        /// </param>
        /// <param name="type">
        /// Type of assignment: Annotate|Review<br/>
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </param>
        /// <param name="createdAt">
        /// Time of assignment<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        public TaskAssignment(
            int assignee,
            int task,
            global::G.TypeEnum? type,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string state = default!)
        {
            this.Assignee = assignee;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.State = state;
            this.Task = task;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAssignment" /> class.
        /// </summary>
        public TaskAssignment()
        {
        }
    }
}