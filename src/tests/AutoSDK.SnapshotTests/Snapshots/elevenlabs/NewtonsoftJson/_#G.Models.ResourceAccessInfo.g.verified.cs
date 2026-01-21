//HintName: G.Models.ResourceAccessInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
    /// </summary>
    public sealed partial class ResourceAccessInfo
    {
        /// <summary>
        /// Whether the user making the request is the creator of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_creator", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCreator { get; set; } = default!;

        /// <summary>
        /// Name of the agent's creator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatorName { get; set; } = default!;

        /// <summary>
        /// Email of the agent's creator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_email", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatorEmail { get; set; } = default!;

        /// <summary>
        /// The role of the user making the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceAccessInfoRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        /// <param name="isCreator">
        /// Whether the user making the request is the creator of the agent
        /// </param>
        /// <param name="creatorName">
        /// Name of the agent's creator
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the agent's creator
        /// </param>
        /// <param name="role">
        /// The role of the user making the request
        /// </param>
        public ResourceAccessInfo(
            bool isCreator,
            string creatorName,
            string creatorEmail,
            global::G.ResourceAccessInfoRole role)
        {
            this.IsCreator = isCreator;
            this.CreatorName = creatorName ?? throw new global::System.ArgumentNullException(nameof(creatorName));
            this.CreatorEmail = creatorEmail ?? throw new global::System.ArgumentNullException(nameof(creatorEmail));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        public ResourceAccessInfo()
        {
        }
    }
}