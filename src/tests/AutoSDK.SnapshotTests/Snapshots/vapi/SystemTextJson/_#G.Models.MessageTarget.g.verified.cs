//HintName: G.Models.MessageTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageTarget
    {
        /// <summary>
        /// This is the role of the message to target.<br/>
        /// If not specified, will find the position in the message history ignoring role (effectively `any`).<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageTargetRoleJsonConverter))]
        public global::G.MessageTargetRole? Role { get; set; }

        /// <summary>
        /// This is the position of the message to target.<br/>
        /// - Negative numbers: Count from end (-1 = most recent, -2 = second most recent)<br/>
        /// - 0: First/oldest message in history<br/>
        /// - Positive numbers: Specific position (0-indexed from start)<br/>
        /// @default -1 (most recent message)<br/>
        /// Example: -1
        /// </summary>
        /// <example>-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public double? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTarget" /> class.
        /// </summary>
        /// <param name="role">
        /// This is the role of the message to target.<br/>
        /// If not specified, will find the position in the message history ignoring role (effectively `any`).<br/>
        /// Example: user
        /// </param>
        /// <param name="position">
        /// This is the position of the message to target.<br/>
        /// - Negative numbers: Count from end (-1 = most recent, -2 = second most recent)<br/>
        /// - 0: First/oldest message in history<br/>
        /// - Positive numbers: Specific position (0-indexed from start)<br/>
        /// @default -1 (most recent message)<br/>
        /// Example: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageTarget(
            global::G.MessageTargetRole? role,
            double? position)
        {
            this.Role = role;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTarget" /> class.
        /// </summary>
        public MessageTarget()
        {
        }
    }
}