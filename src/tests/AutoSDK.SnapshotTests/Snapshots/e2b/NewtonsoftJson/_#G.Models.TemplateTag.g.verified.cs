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
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// Identifier of the build associated with this tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildID", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid BuildID { get; set; } = default!;

        /// <summary>
        /// Time when the tag was assigned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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