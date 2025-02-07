//HintName: G.Models.MessageDeltaUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaUsage
    {
        /// <summary>
        /// The cumulative number of output tokens which were used.<br/>
        /// Example: 503
        /// </summary>
        /// <example>503</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaUsage" /> class.
        /// </summary>
        /// <param name="outputTokens">
        /// The cumulative number of output tokens which were used.<br/>
        /// Example: 503
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaUsage(
            int outputTokens)
        {
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaUsage" /> class.
        /// </summary>
        public MessageDeltaUsage()
        {
        }
    }
}