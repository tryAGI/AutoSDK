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
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRestorePublic" /> class.
        /// </summary>
        /// <param name="versionRef">
        /// Version hash or tag to restore from
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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