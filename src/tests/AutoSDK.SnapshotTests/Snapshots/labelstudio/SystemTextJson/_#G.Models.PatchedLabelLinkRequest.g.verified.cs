//HintName: G.Models.PatchedLabelLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class PatchedLabelLinkRequest
    {
        /// <summary>
        /// Tag name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        public string? FromName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public int? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelLinkRequest" /> class.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLabelLinkRequest(
            string? fromName,
            int? label,
            int? project)
        {
            this.FromName = fromName;
            this.Label = label;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelLinkRequest" /> class.
        /// </summary>
        public PatchedLabelLinkRequest()
        {
        }
    }
}