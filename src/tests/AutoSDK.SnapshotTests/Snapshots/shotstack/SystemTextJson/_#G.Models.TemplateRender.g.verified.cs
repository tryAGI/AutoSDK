//HintName: G.Models.TemplateRender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configure the id and optional merge fields to render a template by id.
    /// </summary>
    public sealed partial class TemplateRender
    {
        /// <summary>
        /// The id of the template to render in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge")]
        public global::System.Collections.Generic.IList<global::G.MergeField>? Merge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRender" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the template to render in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        /// <param name="merge">
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRender(
            string id,
            global::System.Collections.Generic.IList<global::G.MergeField>? merge)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Merge = merge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRender" /> class.
        /// </summary>
        public TemplateRender()
        {
        }
    }
}