//HintName: G.Models.TimelineCommittedEventCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifying information for the git-user
    /// </summary>
    public sealed partial class TimelineCommittedEventCommitter
    {
        /// <summary>
        /// Timestamp of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Date { get; set; } = default!;

        /// <summary>
        /// Git email address of the user<br/>
        /// Example: monalisa.octocat@example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Name of the git user<br/>
        /// Example: Monalisa Octocat
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