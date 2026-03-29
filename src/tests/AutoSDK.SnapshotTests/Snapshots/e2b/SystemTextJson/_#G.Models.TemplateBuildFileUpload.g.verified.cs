//HintName: G.Models.TemplateBuildFileUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildFileUpload
    {
        /// <summary>
        /// Whether the file is already present in the cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Present { get; set; }

        /// <summary>
        /// Url where the file should be uploaded to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildFileUpload" /> class.
        /// </summary>
        /// <param name="present">
        /// Whether the file is already present in the cache
        /// </param>
        /// <param name="url">
        /// Url where the file should be uploaded to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBuildFileUpload(
            bool present,
            string? url)
        {
            this.Present = present;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildFileUpload" /> class.
        /// </summary>
        public TemplateBuildFileUpload()
        {
        }
    }
}