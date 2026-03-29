//HintName: G.Models.TemplateRequestResponseV3.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateRequestResponseV3
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Identifier of the last successful build for given template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildID", Required = global::Newtonsoft.Json.Required.Always)]
        public string BuildID { get; set; } = default!;

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Names of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// Tags assigned to the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Aliases { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRequestResponseV3" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="buildID">
        /// Identifier of the last successful build for given template
        /// </param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="names">
        /// Names of the template
        /// </param>
        /// <param name="tags">
        /// Tags assigned to the template build
        /// </param>
        /// <param name="aliases">
        /// Aliases of the template
        /// </param>
        public TemplateRequestResponseV3(
            string templateID,
            string buildID,
            bool @public,
            global::System.Collections.Generic.IList<string> names,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<string> aliases)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.BuildID = buildID ?? throw new global::System.ArgumentNullException(nameof(buildID));
            this.Public = @public;
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRequestResponseV3" /> class.
        /// </summary>
        public TemplateRequestResponseV3()
        {
        }
    }
}