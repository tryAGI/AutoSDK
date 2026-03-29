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
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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