//HintName: G.Models.AssignTemplateTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignTemplateTagsRequest
    {
        /// <summary>
        /// Target template in "name:tag" format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Tags to assign to the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTemplateTagsRequest" /> class.
        /// </summary>
        /// <param name="target">
        /// Target template in "name:tag" format
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignTemplateTagsRequest(
            string target,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTemplateTagsRequest" /> class.
        /// </summary>
        public AssignTemplateTagsRequest()
        {
        }
    }
}