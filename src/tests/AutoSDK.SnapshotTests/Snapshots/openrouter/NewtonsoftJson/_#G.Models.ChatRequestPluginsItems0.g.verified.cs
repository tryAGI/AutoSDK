//HintName: G.Models.ChatRequestPluginsItems0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequestPluginsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.ChatRequestPluginsItemsOneOf0Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItems0" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="allowedModels">
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </param>
        public ChatRequestPluginsItems0(
            global::G.ChatRequestPluginsItemsOneOf0Id id,
            bool? enabled,
            global::System.Collections.Generic.IList<string>? allowedModels)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.AllowedModels = allowedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItems0" /> class.
        /// </summary>
        public ChatRequestPluginsItems0()
        {
        }
    }
}