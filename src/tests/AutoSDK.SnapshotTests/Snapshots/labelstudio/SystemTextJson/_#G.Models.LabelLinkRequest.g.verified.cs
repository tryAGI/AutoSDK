//HintName: G.Models.LabelLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class LabelLinkRequest
    {
        /// <summary>
        /// Tag name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelLinkRequest" /> class.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelLinkRequest(
            string fromName,
            int label,
            int project)
        {
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Label = label;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelLinkRequest" /> class.
        /// </summary>
        public LabelLinkRequest()
        {
        }
    }
}