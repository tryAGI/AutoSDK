//HintName: G.Models.UpdateVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVersionRequest" /> class.
        /// </summary>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVersionRequest(
            string? versionName,
            string? versionDescription)
        {
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVersionRequest" /> class.
        /// </summary>
        public UpdateVersionRequest()
        {
        }
    }
}