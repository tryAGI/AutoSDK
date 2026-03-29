//HintName: G.Models.TemplateListResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [TemplateListResponse](#tocs_templatelistresponse).
    /// </summary>
    public sealed partial class TemplateListResponseData
    {
        /// <summary>
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// The list of templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplateListResponseItem> Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseData" /> class.
        /// </summary>
        /// <param name="owner">
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="templates">
        /// The list of templates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListResponseData(
            string owner,
            global::System.Collections.Generic.IList<global::G.TemplateListResponseItem> templates)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseData" /> class.
        /// </summary>
        public TemplateListResponseData()
        {
        }
    }
}