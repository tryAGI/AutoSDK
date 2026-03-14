//HintName: G.Models.ListToolServersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of tool servers.
    /// </summary>
    public sealed partial class ListToolServersResponse
    {
        /// <summary>
        /// List of tool servers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_servers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolServer> ToolServers { get; set; } = default!;

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolServersResponse" /> class.
        /// </summary>
        /// <param name="toolServers">
        /// List of tool servers.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListToolServersResponse(
            global::System.Collections.Generic.IList<global::G.ToolServer> toolServers,
            global::G.ListMetadata? metadata)
        {
            this.ToolServers = toolServers ?? throw new global::System.ArgumentNullException(nameof(toolServers));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolServersResponse" /> class.
        /// </summary>
        public ListToolServersResponse()
        {
        }
    }
}