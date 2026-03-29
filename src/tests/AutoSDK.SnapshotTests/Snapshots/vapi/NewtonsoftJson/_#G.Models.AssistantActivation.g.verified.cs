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
        [global::Newtonsoft.Json.JsonProperty("assistantName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantName { get; set; } = default!;

        /// <summary>
        /// This is the ID of the assistant that was active during the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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