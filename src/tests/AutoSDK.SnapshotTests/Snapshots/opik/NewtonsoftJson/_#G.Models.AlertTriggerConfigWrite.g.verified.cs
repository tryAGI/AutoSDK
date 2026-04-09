//HintName: G.Models.AlertTriggerConfigWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTriggerConfigWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter))]
        public global::G.AlertTriggerConfigWriteType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config_value")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConfigValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerConfigWrite" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="configValue"></param>
        public AlertTriggerConfigWrite(
            global::G.AlertTriggerConfigWriteType type,
            global::System.Guid? id,
            global::System.Collections.Generic.Dictionary<string, string>? configValue)
        {
            this.Id = id;
            this.Type = type;
            this.ConfigValue = configValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerConfigWrite" /> class.
        /// </summary>
        public AlertTriggerConfigWrite()
        {
        }
    }
}