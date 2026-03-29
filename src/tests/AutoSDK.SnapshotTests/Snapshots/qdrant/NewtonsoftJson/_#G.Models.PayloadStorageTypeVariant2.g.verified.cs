//HintName: G.Models.PayloadStorageTypeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadStorageTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PayloadStorageTypeVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadStorageTypeVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PayloadStorageTypeVariant2(
            global::G.PayloadStorageTypeVariant2Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadStorageTypeVariant2" /> class.
        /// </summary>
        public PayloadStorageTypeVariant2()
        {
        }
    }
}