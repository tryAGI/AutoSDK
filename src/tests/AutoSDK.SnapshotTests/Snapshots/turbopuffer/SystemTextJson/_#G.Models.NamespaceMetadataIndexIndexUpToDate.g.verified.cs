//HintName: G.Models.NamespaceMetadataIndexIndexUpToDate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamespaceMetadataIndexIndexUpToDate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"up-to-date"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "up-to-date";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataIndexIndexUpToDate" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceMetadataIndexIndexUpToDate(
            string status = "up-to-date")
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataIndexIndexUpToDate" /> class.
        /// </summary>
        public NamespaceMetadataIndexIndexUpToDate()
        {
        }
    }
}