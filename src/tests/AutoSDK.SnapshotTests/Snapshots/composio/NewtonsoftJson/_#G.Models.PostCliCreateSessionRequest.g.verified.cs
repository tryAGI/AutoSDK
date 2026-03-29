//HintName: G.Models.PostCliCreateSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliCreateSessionRequest
    {
        /// <summary>
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.PostCliCreateSessionRequestScope? Scope { get; set; }

        /// <summary>
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionRequest" /> class.
        /// </summary>
        /// <param name="scope">
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="source">
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </param>
        public PostCliCreateSessionRequest(
            global::G.PostCliCreateSessionRequestScope? scope,
            string? source)
        {
            this.Scope = scope;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionRequest" /> class.
        /// </summary>
        public PostCliCreateSessionRequest()
        {
        }
    }
}