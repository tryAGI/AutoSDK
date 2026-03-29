//HintName: G.Models.PromptToolChoiceOneOrMore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolChoiceOneOrMore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"one_or_more"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "one_or_more";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolChoiceOneOrMore" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptToolChoiceOneOrMore(
            string type = "one_or_more")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolChoiceOneOrMore" /> class.
        /// </summary>
        public PromptToolChoiceOneOrMore()
        {
        }
    }
}