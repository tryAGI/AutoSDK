//HintName: G.Models.ArtifactUploadEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactUploadEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: artifact_upload
        /// </summary>
        /// <default>"artifact_upload"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// References to uploaded artifacts<br/>
        /// Example: [{"artifact_id":"art_report_pdf_a3f2","filename":"report.pdf","mime_type":"application/pdf","size_bytes":2048576}]
        /// </summary>
        /// <example>[{"artifact_id":"art_report_pdf_a3f2","filename":"report.pdf","mime_type":"application/pdf","size_bytes":2048576}]</example>
        [global::Newtonsoft.Json.JsonProperty("artifacts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ArtifactReference> Artifacts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactUploadEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: artifact_upload
        /// </param>
        /// <param name="artifacts">
        /// References to uploaded artifacts<br/>
        /// Example: [{"artifact_id":"art_report_pdf_a3f2","filename":"report.pdf","mime_type":"application/pdf","size_bytes":2048576}]
        /// </param>
        public ArtifactUploadEventVariant2(
            string type,
            global::System.Collections.Generic.IList<global::G.ArtifactReference> artifacts)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Artifacts = artifacts ?? throw new global::System.ArgumentNullException(nameof(artifacts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactUploadEventVariant2" /> class.
        /// </summary>
        public ArtifactUploadEventVariant2()
        {
        }
    }
}