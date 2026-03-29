//HintName: G.Models.TemplateListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        public global::System.Collections.Generic.IList<global::G.TemplateResponse>? Templates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextOffset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
        /// </summary>
        /// <param name="templates"></param>
        /// <param name="nextOffset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListResponse(
            global::System.Collections.Generic.IList<global::G.TemplateResponse>? templates,
            int? nextOffset)
        {
            this.Templates = templates;
            this.NextOffset = nextOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
        /// </summary>
        public TemplateListResponse()
        {
        }
    }
}