//HintName: G.Models.ResponseFormatV2Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFormatV2Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFormatV2DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatV2Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ResponseFormatV2Discriminator(
            global::G.ResponseFormatV2DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatV2Discriminator" /> class.
        /// </summary>
        public ResponseFormatV2Discriminator()
        {
        }
    }
}