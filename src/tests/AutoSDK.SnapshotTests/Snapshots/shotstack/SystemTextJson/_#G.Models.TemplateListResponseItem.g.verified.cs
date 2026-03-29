//HintName: G.Models.TemplateListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The individual template item returned with the  [TemplateListResponseData](#tocs_templatelistresponsedata) templates list.
    /// </summary>
    public sealed partial class TemplateListResponseItem
    {
        /// <summary>
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The template name<br/>
        /// Example: My template
        /// </summary>
        /// <example>My template</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The time the template was created.<br/>
        /// Example: 2022-06-10T12:50:21.455Z
        /// </summary>
        /// <example>2022-06-10T12:50:21.455Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// The time the template was last updated.<br/>
        /// Example: 2022-06-22T08:24:30.168Z
        /// </summary>
        /// <example>2022-06-22T08:24:30.168Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        /// <param name="name">
        /// The template name<br/>
        /// Example: My template
        /// </param>
        /// <param name="created">
        /// The time the template was created.<br/>
        /// Example: 2022-06-10T12:50:21.455Z
        /// </param>
        /// <param name="updated">
        /// The time the template was last updated.<br/>
        /// Example: 2022-06-22T08:24:30.168Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListResponseItem(
            string id,
            string name,
            string? created,
            string? updated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseItem" /> class.
        /// </summary>
        public TemplateListResponseItem()
        {
        }
    }
}