//HintName: G.Models.MemoAndLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoAndLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoData")]
        public global::G.Memo? MemoData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::G.MemoLink>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderLinks")]
        public global::System.Collections.Generic.IList<global::G.MemoFolderLink>? FolderLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoAndLinks" /> class.
        /// </summary>
        /// <param name="memoData"></param>
        /// <param name="links"></param>
        /// <param name="folderLinks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoAndLinks(
            global::G.Memo? memoData,
            global::System.Collections.Generic.IList<global::G.MemoLink>? links,
            global::System.Collections.Generic.IList<global::G.MemoFolderLink>? folderLinks)
        {
            this.MemoData = memoData;
            this.Links = links;
            this.FolderLinks = folderLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoAndLinks" /> class.
        /// </summary>
        public MemoAndLinks()
        {
        }
    }
}