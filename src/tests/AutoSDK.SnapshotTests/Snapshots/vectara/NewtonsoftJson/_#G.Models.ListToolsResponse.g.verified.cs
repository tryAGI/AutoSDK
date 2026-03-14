//HintName: G.Models.ListToolsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of tools.
    /// </summary>
    public sealed partial class ListToolsResponse
    {
        /// <summary>
        /// List of tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Tool> Tools { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        /// <param name="tools">
        /// List of tools.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListToolsResponse(
            global::System.Collections.Generic.IList<global::G.Tool> tools,
            global::G.ListMetadata? metadata)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        public ListToolsResponse()
        {
        }
    }
}