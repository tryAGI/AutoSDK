//HintName: G.Models.DependabotAlertSecurityAdvisoryReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A link to additional advisory information.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryReference
    {
        /// <summary>
        /// The URL of the reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}