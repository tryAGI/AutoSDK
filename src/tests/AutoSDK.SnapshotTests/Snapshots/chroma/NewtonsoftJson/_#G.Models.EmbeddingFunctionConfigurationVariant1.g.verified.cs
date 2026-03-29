//HintName: G.Models.EmbeddingFunctionConfigurationVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingFunctionConfigurationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EmbeddingFunctionConfigurationVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingFunctionConfigurationVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        public EmbeddingFunctionConfigurationVariant1(
            global::G.EmbeddingFunctionConfigurationVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingFunctionConfigurationVariant1" /> class.
        /// </summary>
        public EmbeddingFunctionConfigurationVariant1()
        {
        }
    }
}