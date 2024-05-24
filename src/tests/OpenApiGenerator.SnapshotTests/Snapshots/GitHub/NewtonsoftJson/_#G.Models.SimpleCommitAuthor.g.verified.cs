//HintName: G.Models.SimpleCommitAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the Git author
    /// </summary>
    public sealed partial class SimpleCommitAuthor
    {
        /// <summary>
        /// Name of the commit's author
        /// <br/>Example: Monalisa Octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Git email address of the commit's author
        /// <br/>Example: monalisa.octocat@example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}