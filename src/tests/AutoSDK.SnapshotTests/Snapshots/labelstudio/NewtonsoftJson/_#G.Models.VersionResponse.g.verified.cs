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
        [global::Newtonsoft.Json.JsonProperty("backend", Required = global::Newtonsoft.Json.Required.Always)]
        public object Backend { get; set; } = default!;

        /// <summary>
        /// Information about the Data Manager 2.0 component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dm2", Required = global::Newtonsoft.Json.Required.Always)]
        public object Dm2 { get; set; } = default!;

        /// <summary>
        /// Label Studio edition (Community or Enterprise)<br/>
        /// * `Community` - Community<br/>
        /// * `Enterprise` - Enterprise
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edition", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditionEnum Edition { get; set; } = default!;

        /// <summary>
        /// Information about the Label Studio converter component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label-studio-converter", Required = global::Newtonsoft.Json.Required.Always)]
        public object LabelStudioConverter { get; set; } = default!;

        /// <summary>
        /// Information about the Label Studio frontend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label-studio-frontend", Required = global::Newtonsoft.Json.Required.Always)]
        public object LabelStudioFrontend { get; set; } = default!;

        /// <summary>
        /// Information about the Label Studio backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label-studio-os-backend", Required = global::Newtonsoft.Json.Required.Always)]
        public object LabelStudioOsBackend { get; set; } = default!;

        /// <summary>
        /// Information about the Label Studio open source package
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label-studio-os-package", Required = global::Newtonsoft.Json.Required.Always)]
        public object LabelStudioOsPackage { get; set; } = default!;

        /// <summary>
        /// Information about the Label Studio Frontend library
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lsf", Required = global::Newtonsoft.Json.Required.Always)]
        public object Lsf { get; set; } = default!;

        /// <summary>
        /// Current release version of Label Studio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release", Required = global::Newtonsoft.Json.Required.Always)]
        public string Release { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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