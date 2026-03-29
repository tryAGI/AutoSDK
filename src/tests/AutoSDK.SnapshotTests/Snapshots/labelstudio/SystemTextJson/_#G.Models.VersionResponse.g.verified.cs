//HintName: G.Models.VersionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VersionResponse
    {
        /// <summary>
        /// Additional backend information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Backend { get; set; }

        /// <summary>
        /// Information about the Data Manager 2.0 component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dm2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Dm2 { get; set; }

        /// <summary>
        /// Label Studio edition (Community or Enterprise)<br/>
        /// * `Community` - Community<br/>
        /// * `Enterprise` - Enterprise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EditionEnum Edition { get; set; }

        /// <summary>
        /// Information about the Label Studio converter component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label-studio-converter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LabelStudioConverter { get; set; }

        /// <summary>
        /// Information about the Label Studio frontend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label-studio-frontend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LabelStudioFrontend { get; set; }

        /// <summary>
        /// Information about the Label Studio backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label-studio-os-backend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LabelStudioOsBackend { get; set; }

        /// <summary>
        /// Information about the Label Studio open source package
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label-studio-os-package")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LabelStudioOsPackage { get; set; }

        /// <summary>
        /// Information about the Label Studio Frontend library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Lsf { get; set; }

        /// <summary>
        /// Current release version of Label Studio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionResponse" /> class.
        /// </summary>
        /// <param name="backend">
        /// Additional backend information
        /// </param>
        /// <param name="dm2">
        /// Information about the Data Manager 2.0 component
        /// </param>
        /// <param name="edition">
        /// Label Studio edition (Community or Enterprise)<br/>
        /// * `Community` - Community<br/>
        /// * `Enterprise` - Enterprise
        /// </param>
        /// <param name="labelStudioConverter">
        /// Information about the Label Studio converter component
        /// </param>
        /// <param name="labelStudioFrontend">
        /// Information about the Label Studio frontend
        /// </param>
        /// <param name="labelStudioOsBackend">
        /// Information about the Label Studio backend
        /// </param>
        /// <param name="labelStudioOsPackage">
        /// Information about the Label Studio open source package
        /// </param>
        /// <param name="lsf">
        /// Information about the Label Studio Frontend library
        /// </param>
        /// <param name="release">
        /// Current release version of Label Studio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionResponse(
            object backend,
            object dm2,
            global::G.EditionEnum edition,
            object labelStudioConverter,
            object labelStudioFrontend,
            object labelStudioOsBackend,
            object labelStudioOsPackage,
            object lsf,
            string release)
        {
            this.Backend = backend ?? throw new global::System.ArgumentNullException(nameof(backend));
            this.Dm2 = dm2 ?? throw new global::System.ArgumentNullException(nameof(dm2));
            this.Edition = edition;
            this.LabelStudioConverter = labelStudioConverter ?? throw new global::System.ArgumentNullException(nameof(labelStudioConverter));
            this.LabelStudioFrontend = labelStudioFrontend ?? throw new global::System.ArgumentNullException(nameof(labelStudioFrontend));
            this.LabelStudioOsBackend = labelStudioOsBackend ?? throw new global::System.ArgumentNullException(nameof(labelStudioOsBackend));
            this.LabelStudioOsPackage = labelStudioOsPackage ?? throw new global::System.ArgumentNullException(nameof(labelStudioOsPackage));
            this.Lsf = lsf ?? throw new global::System.ArgumentNullException(nameof(lsf));
            this.Release = release ?? throw new global::System.ArgumentNullException(nameof(release));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionResponse" /> class.
        /// </summary>
        public VersionResponse()
        {
        }
    }
}