﻿//HintName: G.Models.RepositoryRulesetLinksSelf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetLinksSelf
    {
        /// <summary>
        /// The URL of the ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinksSelf" /> class.
        /// </summary>
        /// <param name="href">
        /// The URL of the ruleset
        /// </param>
        public RepositoryRulesetLinksSelf(
            string? href)
        {
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinksSelf" /> class.
        /// </summary>
        public RepositoryRulesetLinksSelf()
        {
        }
    }
}