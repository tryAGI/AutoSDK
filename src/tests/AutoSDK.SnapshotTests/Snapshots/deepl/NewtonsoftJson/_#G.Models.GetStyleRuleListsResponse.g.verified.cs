//HintName: G.Models.GetStyleRuleListsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStyleRuleListsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style_rules")]
        public global::System.Collections.Generic.IList<global::G.StyleRuleList>? StyleRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStyleRuleListsResponse" /> class.
        /// </summary>
        /// <param name="styleRules"></param>
        public GetStyleRuleListsResponse(
            global::System.Collections.Generic.IList<global::G.StyleRuleList>? styleRules)
        {
            this.StyleRules = styleRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStyleRuleListsResponse" /> class.
        /// </summary>
        public GetStyleRuleListsResponse()
        {
        }
    }
}