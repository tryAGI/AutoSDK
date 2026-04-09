//HintName: G.Models.SmsSenderVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsSenderVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SmsSenderVariant1TypeJsonConverter))]
        public global::G.SmsSenderVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsSenderVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        public SmsSenderVariant1(
            global::G.SmsSenderVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsSenderVariant1" /> class.
        /// </summary>
        public SmsSenderVariant1()
        {
        }
    }
}