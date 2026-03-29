//HintName: G.Models.PropertiesInterruptData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// content type为interrupt时传输，中断协议
    /// </summary>
    public sealed partial class PropertiesInterruptData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 输入参数,输入节点需要
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties>? RequiredParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesInterruptData" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="eventId"></param>
        /// <param name="requiredParameters">
        /// 输入参数,输入节点需要
        /// </param>
        /// <param name="type"></param>
        public PropertiesInterruptData(
            string? data,
            string? eventId,
            global::System.Collections.Generic.Dictionary<string, global::G.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties>? requiredParameters,
            int? type)
        {
            this.Data = data;
            this.EventId = eventId;
            this.RequiredParameters = requiredParameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesInterruptData" /> class.
        /// </summary>
        public PropertiesInterruptData()
        {
        }
    }
}