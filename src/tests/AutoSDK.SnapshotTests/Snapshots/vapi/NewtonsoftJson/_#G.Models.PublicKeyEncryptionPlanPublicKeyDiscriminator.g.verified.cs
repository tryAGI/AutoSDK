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
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlanPublicKeyDiscriminator" /> class.
        /// </summary>
        /// <param name="format"></param>
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