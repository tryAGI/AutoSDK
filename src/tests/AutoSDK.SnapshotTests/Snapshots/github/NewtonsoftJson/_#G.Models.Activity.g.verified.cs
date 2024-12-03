//HintName: G.Models.Activity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Activity
    /// </summary>
    public sealed partial class Activity
    {
        /// <summary>
        /// Example: 1296269
        /// </summary>
        /// <example>1296269</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit before the activity.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::Newtonsoft.Json.JsonProperty("before", Required = global::Newtonsoft.Json.Required.Always)]
        public string Before { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit after the activity.<br/>
        /// Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </summary>
        /// <example>827efc6d56897b048c772eb4087f854f46256132</example>
        [global::Newtonsoft.Json.JsonProperty("after", Required = global::Newtonsoft.Json.Required.Always)]
        public string After { get; set; } = default!;

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.<br/>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// The time when the activity occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// The type of the activity that was performed.<br/>
        /// Example: force_push
        /// </summary>
        /// <example>force_push</example>
        [global::Newtonsoft.Json.JsonProperty("activity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActivityActivityType ActivityType { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Actor { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1296269
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </param>
        /// <param name="before">
        /// The SHA of the commit before the activity.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="after">
        /// The SHA of the commit after the activity.<br/>
        /// Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </param>
        /// <param name="ref">
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="timestamp">
        /// The time when the activity occurred.
        /// </param>
        /// <param name="activityType">
        /// The type of the activity that was performed.<br/>
        /// Example: force_push
        /// </param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        public Activity(
            int id,
            string nodeId,
            string before,
            string after,
            string @ref,
            global::System.DateTime timestamp,
            global::G.ActivityActivityType activityType,
            global::G.NullableSimpleUser? actor)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
            this.After = after ?? throw new global::System.ArgumentNullException(nameof(after));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Timestamp = timestamp;
            this.ActivityType = activityType;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        public Activity()
        {
        }
    }
}