//HintName: G.Models.AgentsCompletionRequestMessageDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCompletionRequestMessageDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.AgentsCompletionRequestMessageDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCompletionRequestMessageDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        public AgentsCompletionRequestMessageDiscriminator(
            global::G.AgentsCompletionRequestMessageDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCompletionRequestMessageDiscriminator" /> class.
        /// </summary>
        public AgentsCompletionRequestMessageDiscriminator()
        {
        }
    }
}