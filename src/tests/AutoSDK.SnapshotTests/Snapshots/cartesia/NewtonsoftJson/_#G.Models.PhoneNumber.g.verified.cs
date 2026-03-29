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
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the phone number was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the phone number was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the phone number is managed by Cartesia. As of now, this is always true since Cartesia provisions phone numbers for you.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cartesia_managed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCartesiaManaged { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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