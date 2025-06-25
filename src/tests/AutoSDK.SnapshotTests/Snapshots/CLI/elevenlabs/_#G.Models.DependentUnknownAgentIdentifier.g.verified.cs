//HintName: G.Models.DependentUnknownAgentIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that represents an agent dependent on a knowledge base/tools<br/>
    /// to which the user has no direct access.
    /// </summary>
    public sealed partial class DependentUnknownAgentIdentifier
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependentUnknownAgentIdentifierTypeJsonConverter))]
        public global::G.DependentUnknownAgentIdentifierType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependentUnknownAgentIdentifier(
            global::G.DependentUnknownAgentIdentifierType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentIdentifier" /> class.
        /// </summary>
        public DependentUnknownAgentIdentifier()
        {
        }
    }
}