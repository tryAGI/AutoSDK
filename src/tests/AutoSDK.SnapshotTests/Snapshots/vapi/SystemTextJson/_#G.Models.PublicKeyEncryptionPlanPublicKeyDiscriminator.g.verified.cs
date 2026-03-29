//HintName: G.Models.PublicKeyEncryptionPlanPublicKeyDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicKeyEncryptionPlanPublicKeyDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatJsonConverter))]
        public global::G.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlanPublicKeyDiscriminator" /> class.
        /// </summary>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicKeyEncryptionPlanPublicKeyDiscriminator(
            global::G.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlanPublicKeyDiscriminator" /> class.
        /// </summary>
        public PublicKeyEncryptionPlanPublicKeyDiscriminator()
        {
        }
    }
}