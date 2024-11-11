//HintName: G.Models.RepositoryRulesetLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self")]
        public global::G.RepositoryRulesetLinksSelf? Self { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public global::G.RepositoryRulesetLinksHtml? Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="html"></param>
        public RepositoryRulesetLinks(
            global::G.RepositoryRulesetLinksSelf? self,
            global::G.RepositoryRulesetLinksHtml? html)
        {
            this.Self = self;
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinks" /> class.
        /// </summary>
        public RepositoryRulesetLinks()
        {
        }
    }
}