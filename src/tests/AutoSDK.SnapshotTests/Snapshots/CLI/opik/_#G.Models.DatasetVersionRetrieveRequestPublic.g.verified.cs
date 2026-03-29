//HintName: G.Models.DatasetVersionRetrieveRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionRetrieveRequestPublic
    {
        /// <summary>
        /// Version name in format 'vN' (e.g., 'v1', 'v373')<br/>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRetrieveRequestPublic" /> class.
        /// </summary>
        /// <param name="versionName">
        /// Version name in format 'vN' (e.g., 'v1', 'v373')<br/>
        /// Example: v1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetVersionRetrieveRequestPublic(
            string versionName)
        {
            this.VersionName = versionName ?? throw new global::System.ArgumentNullException(nameof(versionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRetrieveRequestPublic" /> class.
        /// </summary>
        public DatasetVersionRetrieveRequestPublic()
        {
        }
    }
}