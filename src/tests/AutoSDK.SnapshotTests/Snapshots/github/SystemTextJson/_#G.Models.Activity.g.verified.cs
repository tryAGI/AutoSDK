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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The SHA of the commit before the activity.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Before { get; set; }

        /// <summary>
        /// The SHA of the commit after the activity.<br/>
        /// Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </summary>
        /// <example>827efc6d56897b048c772eb4087f854f46256132</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string After { get; set; }

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.<br/>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// The time when the activity occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The type of the activity that was performed.<br/>
        /// Example: force_push
        /// </summary>
        /// <example>force_push</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActivityActivityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActivityActivityType ActivityType { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Actor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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