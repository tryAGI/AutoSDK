//HintName: G.Models.ChatConnectorOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides the connector with different settings at request time. The key/value pairs of this object are specific to each connector.<br/>
    /// For example, the connector `web-search` supports the `site` option, which limits search results to the specified domain.
    /// </summary>
    public sealed partial class ChatConnectorOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatConnectorOptions" /> class.
        /// </summary>
        public ChatConnectorOptions(
 )
        {
        }
    }
}