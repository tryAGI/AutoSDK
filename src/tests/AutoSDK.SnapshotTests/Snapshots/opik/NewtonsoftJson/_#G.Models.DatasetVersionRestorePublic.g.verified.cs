//HintName: G.Models.DatasetVersionRestorePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionRestorePublic
    {
        /// <summary>
        /// Version hash or tag to restore from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionRef { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRestorePublic" /> class.
        /// </summary>
        /// <param name="versionRef">
        /// Version hash or tag to restore from
        /// </param>
        public DatasetVersionRestorePublic(
            string versionRef)
        {
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRestorePublic" /> class.
        /// </summary>
        public DatasetVersionRestorePublic()
        {
        }
    }
}