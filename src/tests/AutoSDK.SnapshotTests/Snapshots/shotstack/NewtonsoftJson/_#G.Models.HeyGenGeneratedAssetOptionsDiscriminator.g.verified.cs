//HintName: G.Models.HeyGenGeneratedAssetOptionsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeyGenGeneratedAssetOptionsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HeyGenGeneratedAssetOptionsDiscriminatorTypeJsonConverter))]
        public global::G.HeyGenGeneratedAssetOptionsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public HeyGenGeneratedAssetOptionsDiscriminator(
            global::G.HeyGenGeneratedAssetOptionsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        public HeyGenGeneratedAssetOptionsDiscriminator()
        {
        }
    }
}