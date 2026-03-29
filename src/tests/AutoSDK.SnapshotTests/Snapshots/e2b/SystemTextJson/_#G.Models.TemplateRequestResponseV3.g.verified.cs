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
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Identifier of the last successful build for given template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildID { get; set; }

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Names of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Tags assigned to the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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