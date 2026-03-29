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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestPluginsItemsOneOf4IdJsonConverter))]
        public global::G.ChatRequestPluginsItemsOneOf4Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItems4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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