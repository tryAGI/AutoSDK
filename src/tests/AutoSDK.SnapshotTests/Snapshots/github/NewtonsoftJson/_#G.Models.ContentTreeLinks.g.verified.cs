//HintName: G.Models.ContentTreeLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentTreeLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git")]
        public string? Git { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public string? Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public string Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTreeLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="git"></param>
        /// <param name="html"></param>
        public ContentTreeLinks(
            string self,
            string? git,
            string? html)
        {
            this.Git = git;
            this.Html = html;
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTreeLinks" /> class.
        /// </summary>
        public ContentTreeLinks()
        {
        }
    }
}