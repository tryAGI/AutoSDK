//HintName: G.Models.ListGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListGroup.
    /// </summary>
    public sealed partial class ListGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string SelfRef { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.RefItem? Parent { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children")]
        public global::System.Collections.Generic.IList<global::G.RefItem>? Children { get; set; }

        /// <summary>
        /// ContentLayer.<br/>
        /// Default Value: body
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_layer")]
        public global::G.ContentLayer? ContentLayer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.BaseMeta? Meta { get; set; }

        /// <summary>
        /// Default Value: group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup" /> class.
        /// </summary>
        /// <param name="selfRef"></param>
        /// <param name="parent"></param>
        /// <param name="children">
        /// Default Value: []
        /// </param>
        /// <param name="contentLayer">
        /// ContentLayer.<br/>
        /// Default Value: body
        /// </param>
        /// <param name="meta"></param>
        /// <param name="name">
        /// Default Value: group
        /// </param>
        /// <param name="label">
        /// Default Value: list
        /// </param>
        public ListGroup(
            string selfRef,
            global::G.RefItem? parent,
            global::System.Collections.Generic.IList<global::G.RefItem>? children,
            global::G.ContentLayer? contentLayer,
            global::G.BaseMeta? meta,
            string? name,
            string? label)
        {
            this.SelfRef = selfRef ?? throw new global::System.ArgumentNullException(nameof(selfRef));
            this.Parent = parent;
            this.Children = children;
            this.ContentLayer = contentLayer;
            this.Meta = meta;
            this.Name = name;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup" /> class.
        /// </summary>
        public ListGroup()
        {
        }
    }
}