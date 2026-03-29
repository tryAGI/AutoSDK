//HintName: G.Models.AssistantActivation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantActivation
    {
        /// <summary>
        /// This is the name of the assistant that was active during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantName { get; set; }

        /// <summary>
        /// This is the ID of the assistant that was active during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantActivation" /> class.
        /// </summary>
        /// <param name="assistantName">
        /// This is the name of the assistant that was active during the call.
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant that was active during the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantActivation(
            string assistantName,
            string? assistantId)
        {
            this.AssistantName = assistantName ?? throw new global::System.ArgumentNullException(nameof(assistantName));
            this.AssistantId = assistantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantActivation" /> class.
        /// </summary>
        public AssistantActivation()
        {
        }
    }
}