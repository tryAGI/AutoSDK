//HintName: G.Models.ConversationConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the text_only field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="textOnly">
        /// Whether to allow overriding the text_only field.<br/>
        /// Default Value: false
        /// </param>
        public ConversationConfigOverrideConfig(
            bool? textOnly)
        {
            this.TextOnly = textOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigOverrideConfig" /> class.
        /// </summary>
        public ConversationConfigOverrideConfig()
        {
        }
    }
}