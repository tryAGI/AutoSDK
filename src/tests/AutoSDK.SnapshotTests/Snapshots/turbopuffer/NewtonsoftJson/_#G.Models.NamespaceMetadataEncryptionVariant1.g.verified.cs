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
        [global::Newtonsoft.Json.JsonProperty("sse", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Sse { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant1" /> class.
        /// </summary>
        /// <param name="sse">
        /// Always true. Indicates that the namespace is encrypted with SSE.
        /// </param>
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