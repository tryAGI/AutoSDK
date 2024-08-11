//HintName: G.Models.DependabotAlertSecurityAdvisoryIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An advisory identifier.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryIdentifier
    {
        /// <summary>
        /// The type of advisory identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DependabotAlertSecurityAdvisoryIdentifierTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertSecurityAdvisoryIdentifierType Type { get; set; }

        /// <summary>
        /// The value of the advisory identifer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}