//HintName: G.Models.TemplateTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateTag
    {
        /// <summary>
        /// The tag name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Identifier of the build associated with this tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// Time when the tag was assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTag" /> class.
        /// </summary>
        /// <param name="tag">
        /// The tag name
        /// </param>
        /// <param name="buildID">
        /// Identifier of the build associated with this tag
        /// </param>
        /// <param name="createdAt">
        /// Time when the tag was assigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTag(
            string tag,
            global::System.Guid buildID,
            global::System.DateTime createdAt)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.BuildID = buildID;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTag" /> class.
        /// </summary>
        public TemplateTag()
        {
        }
    }
}