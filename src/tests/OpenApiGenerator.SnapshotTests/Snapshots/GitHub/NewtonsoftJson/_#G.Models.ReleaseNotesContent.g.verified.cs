//HintName: G.Models.ReleaseNotesContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generated name and body describing a release
    /// </summary>
    public sealed partial class ReleaseNotesContent
    {
        /// <summary>
        /// The generated name of the release
        /// <br/>Example: Release v1.0.0 is now available!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The generated body describing the contents of the release supporting markdown formatting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}