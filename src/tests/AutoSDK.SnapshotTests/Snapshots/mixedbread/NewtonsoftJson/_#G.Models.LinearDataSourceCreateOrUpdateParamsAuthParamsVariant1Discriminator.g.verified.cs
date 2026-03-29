//HintName: G.Models.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator(
            global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator" /> class.
        /// </summary>
        public LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator()
        {
        }
    }
}