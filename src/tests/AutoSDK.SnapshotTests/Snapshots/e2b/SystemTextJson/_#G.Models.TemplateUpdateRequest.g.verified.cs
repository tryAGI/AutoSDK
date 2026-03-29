//HintName: G.Models.TemplateUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateUpdateRequest
    {
        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateRequest" /> class.
        /// </summary>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateUpdateRequest(
            bool? @public)
        {
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateRequest" /> class.
        /// </summary>
        public TemplateUpdateRequest()
        {
        }
    }
}