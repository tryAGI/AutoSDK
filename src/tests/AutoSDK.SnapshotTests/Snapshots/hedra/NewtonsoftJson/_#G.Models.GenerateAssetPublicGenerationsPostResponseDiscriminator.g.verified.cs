//HintName: G.Models.GenerateAssetPublicGenerationsPostResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateAssetPublicGenerationsPostResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeJsonConverter))]
        public global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAssetPublicGenerationsPostResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public GenerateAssetPublicGenerationsPostResponseDiscriminator(
            global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAssetPublicGenerationsPostResponseDiscriminator" /> class.
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponseDiscriminator()
        {
        }
    }
}