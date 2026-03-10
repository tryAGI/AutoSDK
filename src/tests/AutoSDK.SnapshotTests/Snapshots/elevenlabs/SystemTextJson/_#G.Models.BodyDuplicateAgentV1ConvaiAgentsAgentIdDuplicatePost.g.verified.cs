//HintName: G.Models.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost
    {
        /// <summary>
        /// A name to make the agent easier to find
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost" /> class.
        /// </summary>
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost" /> class.
        /// </summary>
        public BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost()
        {
        }
    }
}