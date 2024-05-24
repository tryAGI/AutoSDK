//HintName: G.Models.DependabotAlertSecurityAdvisoryReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A link to additional advisory information.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryReferences
    {
        /// <summary>
        /// The URL of the reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}