//HintName: G.Models.ComponentDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ComponentDefinition describes a certain type of Component.
    /// </summary>
    public sealed partial class ComponentDefinition
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Component definition UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Component definition resource ID (used in `name` as the last segment). This<br/>
        /// conforms to RFC-1034, which restricts to letters, numbers, and hyphen,<br/>
        /// with the first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Component definition title.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Component definition documentation URL.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Component definition icon. This is a path that's relative to the root of<br/>
        /// the component implementation (see `source_url`) and that allows<br/>
        /// frontend applications to pull and locate the icons.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Component definition specification.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public global::G.Spec? Spec { get; set; }

        /// <summary>
        /// Component definition type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComponentTypeJsonConverter))]
        public global::G.ComponentType? Type { get; set; }

        /// <summary>
        /// Component definition tombstone. If true, this configuration is permanently<br/>
        /// off. Otherwise, the configuration is active.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tombstone")]
        public bool? Tombstone { get; set; }

        /// <summary>
        /// The public flag determines whether this connector definition is available<br/>
        /// to all workspaces.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Component definition custom flag, i.e., whether this is a custom<br/>
        /// component definition.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public bool? Custom { get; set; }

        /// <summary>
        /// Component definition vendor name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Vendor-specific attributes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorAttributes")]
        public object? VendorAttributes { get; set; }

        /// <summary>
        /// Source code URL. This points to the source code where the component is<br/>
        /// implemented.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Component definition version. This is a string that fulfills the SemVer<br/>
        /// specification (e.g. `1.0.0-beta`).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// List of tasks that can be executed by the component.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::System.Collections.Generic.IList<global::G.ComponentTask>? Tasks { get; set; }

        /// <summary>
        /// Short description of the component.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Release stage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseStage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComponentDefinitionReleaseStageJsonConverter))]
        public global::G.ComponentDefinitionReleaseStage? ReleaseStage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Component definition UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Component definition resource ID (used in `name` as the last segment). This<br/>
        /// conforms to RFC-1034, which restricts to letters, numbers, and hyphen,<br/>
        /// with the first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="title">
        /// Component definition title.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="documentationUrl">
        /// Component definition documentation URL.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="icon">
        /// Component definition icon. This is a path that's relative to the root of<br/>
        /// the component implementation (see `source_url`) and that allows<br/>
        /// frontend applications to pull and locate the icons.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="spec">
        /// Component definition specification.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Component definition type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tombstone">
        /// Component definition tombstone. If true, this configuration is permanently<br/>
        /// off. Otherwise, the configuration is active.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="public">
        /// The public flag determines whether this connector definition is available<br/>
        /// to all workspaces.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="custom">
        /// Component definition custom flag, i.e., whether this is a custom<br/>
        /// component definition.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vendor">
        /// Component definition vendor name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vendorAttributes">
        /// Vendor-specific attributes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sourceUrl">
        /// Source code URL. This points to the source code where the component is<br/>
        /// implemented.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="version">
        /// Component definition version. This is a string that fulfills the SemVer<br/>
        /// specification (e.g. `1.0.0-beta`).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tasks">
        /// List of tasks that can be executed by the component.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Short description of the component.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="releaseStage">
        /// Release stage.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComponentDefinition(
            string? name,
            string? uid,
            string? id,
            string? title,
            string? documentationUrl,
            string? icon,
            global::G.Spec? spec,
            global::G.ComponentType? type,
            bool? tombstone,
            bool? @public,
            bool? custom,
            string? vendor,
            object? vendorAttributes,
            string? sourceUrl,
            string? version,
            global::System.Collections.Generic.IList<global::G.ComponentTask>? tasks,
            string? description,
            global::G.ComponentDefinitionReleaseStage? releaseStage)
        {
            this.Name = name;
            this.Uid = uid;
            this.Id = id;
            this.Title = title;
            this.DocumentationUrl = documentationUrl;
            this.Icon = icon;
            this.Spec = spec;
            this.Type = type;
            this.Tombstone = tombstone;
            this.Public = @public;
            this.Custom = custom;
            this.Vendor = vendor;
            this.VendorAttributes = vendorAttributes;
            this.SourceUrl = sourceUrl;
            this.Version = version;
            this.Tasks = tasks;
            this.Description = description;
            this.ReleaseStage = releaseStage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentDefinition" /> class.
        /// </summary>
        public ComponentDefinition()
        {
        }
    }
}