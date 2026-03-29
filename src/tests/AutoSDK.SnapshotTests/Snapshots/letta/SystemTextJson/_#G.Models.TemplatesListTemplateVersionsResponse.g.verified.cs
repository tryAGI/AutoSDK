//HintName: G.Models.TemplatesListTemplateVersionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesListTemplateVersionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplatesListTemplateVersionsResponseVersion> Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponse" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="hasNextPage"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesListTemplateVersionsResponse(
            global::System.Collections.Generic.IList<global::G.TemplatesListTemplateVersionsResponseVersion> versions,
            bool hasNextPage,
            double totalCount)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.HasNextPage = hasNextPage;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponse" /> class.
        /// </summary>
        public TemplatesListTemplateVersionsResponse()
        {
        }
    }
}