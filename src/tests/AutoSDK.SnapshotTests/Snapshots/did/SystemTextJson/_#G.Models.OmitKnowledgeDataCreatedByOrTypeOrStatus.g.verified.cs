//HintName: G.Models.OmitKnowledgeDataCreatedByOrTypeOrStatus.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class OmitKnowledgeDataCreatedByOrTypeOrStatus
    {
        /// <summary>
        /// Description of knowledge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Name of knowledge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask<br/>
        /// Use agent.starter_messages instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitKnowledgeDataCreatedByOrTypeOrStatus" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of knowledge
        /// </param>
        /// <param name="name">
        /// Name of knowledge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OmitKnowledgeDataCreatedByOrTypeOrStatus(
            string description,
            string name)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitKnowledgeDataCreatedByOrTypeOrStatus" /> class.
        /// </summary>
        public OmitKnowledgeDataCreatedByOrTypeOrStatus()
        {
        }
    }
}