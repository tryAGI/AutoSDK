//HintName: G.Models.PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus
    {
        /// <summary>
        /// Description of knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Name of knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask<br/>
        /// Use agent.starter_messages instead
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of knowledge
        /// </param>
        /// <param name="name">
        /// Name of knowledge
        /// </param>
        public PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus(
            string description,
            string name)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus" /> class.
        /// </summary>
        public PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus()
        {
        }
    }
}