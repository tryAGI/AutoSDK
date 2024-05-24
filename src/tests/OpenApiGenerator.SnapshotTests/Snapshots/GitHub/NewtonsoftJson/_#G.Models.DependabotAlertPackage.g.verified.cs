//HintName: G.Models.DependabotAlertPackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the vulnerable package.
    /// </summary>
    public sealed partial class DependabotAlertPackage
    {
        /// <summary>
        /// The package's language or package management ecosystem.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ecosystem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ecosystem { get; set; } = default!;

        /// <summary>
        /// The unique package name within its ecosystem.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}