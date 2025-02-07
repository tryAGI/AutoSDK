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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDg6UmVhY3Rpb24x
        /// </summary>
        /// <example>MDg6UmVhY3Rpb24x</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// The reaction to use<br/>
        /// Example: heart
        /// </summary>
        /// <example>heart</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReactionContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReactionContent Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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