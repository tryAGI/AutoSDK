//HintName: G.Models.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter))]
        public global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator(
            global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator" /> class.
        /// </summary>
        public LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator()
        {
        }
    }
}