//HintName: G.Models.TemplateAliasResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateAliasResponse
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateAliasResponse" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateAliasResponse(
            string templateID,
            bool @public)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateAliasResponse" /> class.
        /// </summary>
        public TemplateAliasResponse()
        {
        }
    }
}