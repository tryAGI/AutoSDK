//HintName: G.Models.Encryption2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encryption configuration for a namespace.
    /// </summary>
    public sealed partial class Encryption2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cmek")]
        public global::G.EncryptionCmek? Cmek { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Encryption2" /> class.
        /// </summary>
        /// <param name="cmek"></param>
        public Encryption2(
            global::G.EncryptionCmek? cmek)
        {
            this.Cmek = cmek;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Encryption2" /> class.
        /// </summary>
        public Encryption2()
        {
        }
    }
}