//HintName: G.Models.KeyVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MetadataField")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetadataField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVariant5" /> class.
        /// </summary>
        /// <param name="metadataField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyVariant5(
            string metadataField)
        {
            this.MetadataField = metadataField ?? throw new global::System.ArgumentNullException(nameof(metadataField));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVariant5" /> class.
        /// </summary>
        public KeyVariant5()
        {
        }
    }
}