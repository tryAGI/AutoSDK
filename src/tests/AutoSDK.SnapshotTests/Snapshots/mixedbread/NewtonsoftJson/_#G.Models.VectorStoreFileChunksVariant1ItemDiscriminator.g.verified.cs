//HintName: G.Models.VectorStoreFileChunksVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreFileChunksVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public VectorStoreFileChunksVariant1ItemDiscriminator(
            global::G.VectorStoreFileChunksVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        public VectorStoreFileChunksVariant1ItemDiscriminator()
        {
        }
    }
}