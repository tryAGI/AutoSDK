//HintName: G.Models.ReposCreateOrUpdateFileContentsRequestCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The person that committed the file. Default: the authenticated user.
    /// </summary>
    public sealed partial class ReposCreateOrUpdateFileContentsRequestCommitter
    {
        /// <summary>
        /// The name of the author or committer of the commit. You'll receive a `422` status code if `name` is omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The email of the author or committer of the commit. You'll receive a `422` status code if `email` is omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// <br/>Example: "2013-01-05T13:13:22+05:00"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}