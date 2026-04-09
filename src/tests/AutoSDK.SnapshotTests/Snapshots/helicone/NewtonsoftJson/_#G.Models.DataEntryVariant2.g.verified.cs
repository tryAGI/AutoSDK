//HintName: G.Models.DataEntryVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataEntryVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DataEntryVariant2TypeJsonConverter))]
        public global::G.DataEntryVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntryVariant2" /> class.
        /// </summary>
        /// <param name="inputKey"></param>
        /// <param name="type"></param>
        public DataEntryVariant2(
            string inputKey,
            global::G.DataEntryVariant2Type type)
        {
            this.InputKey = inputKey ?? throw new global::System.ArgumentNullException(nameof(inputKey));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntryVariant2" /> class.
        /// </summary>
        public DataEntryVariant2()
        {
        }
    }
}