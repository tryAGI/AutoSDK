//HintName: G.Models.AssignedTemplateTags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignedTemplateTags
    {
        /// <summary>
        /// Assigned tags of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Identifier of the build associated with these tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedTemplateTags" /> class.
        /// </summary>
        /// <param name="tags">
        /// Assigned tags of the template
        /// </param>
        /// <param name="buildID">
        /// Identifier of the build associated with these tags
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignedTemplateTags(
            global::System.Collections.Generic.IList<string> tags,
            global::System.Guid buildID)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.BuildID = buildID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedTemplateTags" /> class.
        /// </summary>
        public AssignedTemplateTags()
        {
        }
    }
}