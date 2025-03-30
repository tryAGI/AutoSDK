//HintName: G.Models.BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost
    {
        /// <summary>
        /// A name to help identify a particular agent secret<br/>
        /// Example: MY API KEY
        /// </summary>
        /// <example>MY API KEY</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A value to be encrypted and used by the agent<br/>
        /// Example: sk_api_12354abc
        /// </summary>
        /// <example>sk_api_12354abc</example>
        [global::Newtonsoft.Json.JsonProperty("secret_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost" /> class.
        /// </summary>
        /// <param name="name">
        /// A name to help identify a particular agent secret<br/>
        /// Example: MY API KEY
        /// </param>
        /// <param name="secretValue">
        /// A value to be encrypted and used by the agent<br/>
        /// Example: sk_api_12354abc
        /// </param>
        public BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost(
            string name,
            string secretValue)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SecretValue = secretValue ?? throw new global::System.ArgumentNullException(nameof(secretValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost" /> class.
        /// </summary>
        public BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost()
        {
        }
    }
}