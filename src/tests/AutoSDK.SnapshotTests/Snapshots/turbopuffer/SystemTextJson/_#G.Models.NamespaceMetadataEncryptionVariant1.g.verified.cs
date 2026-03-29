//HintName: G.Models.NamespaceMetadataEncryptionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamespaceMetadataEncryptionVariant1
    {
        /// <summary>
        /// Always true. Indicates that the namespace is encrypted with SSE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Sse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant1" /> class.
        /// </summary>
        /// <param name="sse">
        /// Always true. Indicates that the namespace is encrypted with SSE.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceMetadataEncryptionVariant1(
            bool sse)
        {
            this.Sse = sse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant1" /> class.
        /// </summary>
        public NamespaceMetadataEncryptionVariant1()
        {
        }
    }
}