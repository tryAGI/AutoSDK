//HintName: G.Models.Reaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reactions to conversations provide a way to help people express their feelings more simply and effectively.
    /// </summary>
    public sealed partial class Reaction
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDg6UmVhY3Rpb24x
        /// </summary>
        /// <example>MDg6UmVhY3Rpb24x</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// The reaction to use<br/>
        /// Example: heart
        /// </summary>
        /// <example>heart</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReactionContent Content { get; set; } = default!;

        /// <summary>
        /// Example: 2016-05-20T20:09:31Z
        /// </summary>
        /// <example>2016-05-20T20:09:31Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6UmVhY3Rpb24x
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="content">
        /// The reaction to use<br/>
        /// Example: heart
        /// </param>
        /// <param name="createdAt">
        /// Example: 2016-05-20T20:09:31Z
        /// </param>
        public Reaction(
            int id,
            string nodeId,
            global::G.NullableSimpleUser? user,
            global::G.ReactionContent content,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Content = content;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        public Reaction()
        {
        }
    }
}