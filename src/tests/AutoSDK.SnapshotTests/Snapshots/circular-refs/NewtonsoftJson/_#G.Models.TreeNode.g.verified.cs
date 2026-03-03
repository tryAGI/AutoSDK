//HintName: G.Models.TreeNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TreeNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children")]
        public global::System.Collections.Generic.IList<global::G.TreeNode>? Children { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.TreeNode? Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="children"></param>
        /// <param name="parent"></param>
        public TreeNode(
            string? id,
            string? name,
            global::System.Collections.Generic.IList<global::G.TreeNode>? children,
            global::G.TreeNode? parent)
        {
            this.Id = id;
            this.Name = name;
            this.Children = children;
            this.Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode" /> class.
        /// </summary>
        public TreeNode()
        {
        }
    }
}