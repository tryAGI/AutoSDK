//HintName: G.Models.MemosFoldersAndLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemosFoldersAndLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memos")]
        public global::System.Collections.Generic.IList<global::G.Memo>? Memos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folders")]
        public global::System.Collections.Generic.IList<global::G.MemoFolder>? Folders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<global::G.MemoLink>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderLinks")]
        public global::System.Collections.Generic.IList<global::G.MemoFolderLink>? FolderLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemosFoldersAndLinks" /> class.
        /// </summary>
        /// <param name="memos"></param>
        /// <param name="folders"></param>
        /// <param name="links"></param>
        /// <param name="folderLinks"></param>
        public MemosFoldersAndLinks(
            global::System.Collections.Generic.IList<global::G.Memo>? memos,
            global::System.Collections.Generic.IList<global::G.MemoFolder>? folders,
            global::System.Collections.Generic.IList<global::G.MemoLink>? links,
            global::System.Collections.Generic.IList<global::G.MemoFolderLink>? folderLinks)
        {
            this.Memos = memos;
            this.Folders = folders;
            this.Links = links;
            this.FolderLinks = folderLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemosFoldersAndLinks" /> class.
        /// </summary>
        public MemosFoldersAndLinks()
        {
        }
    }
}