//HintName: G.Models.PhoneNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A phone number that can be used to make calls to your agent.
    /// </summary>
    public sealed partial class PhoneNumber
    {
        /// <summary>
        /// The ID of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// The UTC timestamp when the phone number was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The UTC timestamp when the phone number was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether the phone number is managed by Cartesia. As of now, this is always true since Cartesia provisions phone numbers for you.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cartesia_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCartesiaManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent.
        /// </param>
        /// <param name="number">
        /// The phone number.
        /// </param>
        /// <param name="createdAt">
        /// The UTC timestamp when the phone number was created.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC timestamp when the phone number was last updated.
        /// </param>
        /// <param name="isCartesiaManaged">
        /// Whether the phone number is managed by Cartesia. As of now, this is always true since Cartesia provisions phone numbers for you.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumber(
            string agentId,
            string number,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool isCartesiaManaged)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsCartesiaManaged = isCartesiaManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        public PhoneNumber()
        {
        }
    }
}