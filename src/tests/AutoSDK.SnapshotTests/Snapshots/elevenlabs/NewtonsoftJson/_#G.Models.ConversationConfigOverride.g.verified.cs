//HintName: G.Models.ConversationConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigOverride
    {
        /// <summary>
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigOverride" /> class.
        /// </summary>
        /// <param name="textOnly">
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </param>
        public ConversationConfigOverride(
            bool? textOnly)
        {
            this.TextOnly = textOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigOverride" /> class.
        /// </summary>
        public ConversationConfigOverride()
        {
        }
    }
}