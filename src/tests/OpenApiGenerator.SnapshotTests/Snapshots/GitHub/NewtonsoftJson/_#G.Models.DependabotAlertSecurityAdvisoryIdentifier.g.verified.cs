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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertSecurityAdvisoryIdentifierType Type { get; set; } = default!;

        /// <summary>
        /// The value of the advisory identifer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}