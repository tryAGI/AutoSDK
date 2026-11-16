//HintName: G.Models.Encryption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encryption configuration for a namespace.
    /// </summary>
    public sealed partial class Encryption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        public global::G.EncryptionCmek? Cmek { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Encryption" /> class.
        /// </summary>
        /// <param name="cmek"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Encryption(
            global::G.EncryptionCmek? cmek)
        {
            this.Cmek = cmek;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Encryption" /> class.
        /// </summary>
        public Encryption()
        {
        }

    }
}