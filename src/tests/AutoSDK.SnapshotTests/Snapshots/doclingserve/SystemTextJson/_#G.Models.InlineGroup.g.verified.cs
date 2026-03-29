//HintName: G.Models.InlineGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// InlineGroup.
    /// </summary>
    public sealed partial class InlineGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SelfRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::G.RefItem? Parent { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::G.RefItem>? Children { get; set; }

        /// <summary>
        /// ContentLayer.<br/>
        /// Default Value: body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_layer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentLayerJsonConverter))]
        public global::G.ContentLayer? ContentLayer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.BaseMeta? Meta { get; set; }

        /// <summary>
        /// Default Value: group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: inline
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineGroup" /> class.
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
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineGroup(
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
        /// Initializes a new instance of the <see cref="InlineGroup" /> class.
        /// </summary>
        public InlineGroup()
        {
        }
    }
}