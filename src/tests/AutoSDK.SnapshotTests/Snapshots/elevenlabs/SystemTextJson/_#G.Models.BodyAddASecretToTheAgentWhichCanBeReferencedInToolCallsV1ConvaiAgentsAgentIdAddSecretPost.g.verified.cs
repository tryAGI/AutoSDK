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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A value to be encrypted and used by the agent<br/>
        /// Example: sk_api_12354abc
        /// </summary>
        /// <example>sk_api_12354abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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