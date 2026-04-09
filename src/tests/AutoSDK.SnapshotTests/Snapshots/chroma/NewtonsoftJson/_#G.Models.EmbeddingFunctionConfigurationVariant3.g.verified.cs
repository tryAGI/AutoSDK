//HintName: G.Models.EmbeddingFunctionConfigurationVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingFunctionConfigurationVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingFunctionConfigurationVariant3TypeJsonConverter))]
        public global::G.EmbeddingFunctionConfigurationVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingFunctionConfigurationVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        public EmbeddingFunctionConfigurationVariant3(
            global::G.EmbeddingFunctionConfigurationVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingFunctionConfigurationVariant3" /> class.
        /// </summary>
        public EmbeddingFunctionConfigurationVariant3()
        {
        }
    }
}