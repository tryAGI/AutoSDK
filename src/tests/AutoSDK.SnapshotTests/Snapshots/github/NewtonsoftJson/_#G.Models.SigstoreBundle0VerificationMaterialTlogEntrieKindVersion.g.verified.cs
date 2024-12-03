//HintName: G.Models.SigstoreBundle0VerificationMaterialTlogEntrieKindVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialTlogEntrieKindVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieKindVersion" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="version"></param>
        public SigstoreBundle0VerificationMaterialTlogEntrieKindVersion(
            string? kind,
            string? version)
        {
            this.Kind = kind;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieKindVersion" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialTlogEntrieKindVersion()
        {
        }
    }
}