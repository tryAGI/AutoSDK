//HintName: G.Models.ContentTreeEntrieLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentTreeEntrieLinks
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
        /// Initializes a new instance of the <see cref="ContentTreeEntrieLinks" /> class.
        /// </summary>
        /// <param name="git"></param>
        /// <param name="html"></param>
        /// <param name="self"></param>
        public ContentTreeEntrieLinks(
            string self,
            string? git,
            string? html)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Git = git;
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTreeEntrieLinks" /> class.
        /// </summary>
        public ContentTreeEntrieLinks()
        {
        }
    }
}