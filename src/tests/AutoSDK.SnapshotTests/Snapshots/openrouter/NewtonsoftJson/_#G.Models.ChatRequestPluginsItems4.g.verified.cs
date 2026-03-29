//HintName: G.Models.ChatRequestPluginsItems4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequestPluginsItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.ChatRequestPluginsItemsOneOf4Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItems4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </param>
        public ChatRequestPluginsItems4(
            global::G.ChatRequestPluginsItemsOneOf4Id id,
            bool? enabled)
        {
            this.Id = id;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItems4" /> class.
        /// </summary>
        public ChatRequestPluginsItems4()
        {
        }
    }
}