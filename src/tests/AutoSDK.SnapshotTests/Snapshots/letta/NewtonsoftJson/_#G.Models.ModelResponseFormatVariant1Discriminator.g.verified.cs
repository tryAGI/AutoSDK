//HintName: G.Models.ModelResponseFormatVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponseFormatVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeJsonConverter))]
        public global::G.ModelResponseFormatVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseFormatVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ModelResponseFormatVariant1Discriminator(
            global::G.ModelResponseFormatVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseFormatVariant1Discriminator" /> class.
        /// </summary>
        public ModelResponseFormatVariant1Discriminator()
        {
        }
    }
}