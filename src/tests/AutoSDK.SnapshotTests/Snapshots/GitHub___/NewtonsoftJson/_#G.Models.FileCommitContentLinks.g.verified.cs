//HintName: G.Models.FileCommitContentLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitContentLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self")]
        public string? Self { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitContentLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="git"></param>
        /// <param name="html"></param>
        public FileCommitContentLinks(
            string? self,
            string? git,
            string? html)
        {
            this.Self = self;
            this.Git = git;
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitContentLinks" /> class.
        /// </summary>
        public FileCommitContentLinks()
        {
        }
    }
}