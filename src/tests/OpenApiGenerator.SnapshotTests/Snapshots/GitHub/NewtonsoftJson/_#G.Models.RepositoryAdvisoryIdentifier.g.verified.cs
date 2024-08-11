//HintName: G.Models.RepositoryAdvisoryIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryIdentifier
    {
        /// <summary>
        /// The type of identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryIdentifierType Type { get; set; } = default!;

        /// <summary>
        /// The identifier value.
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