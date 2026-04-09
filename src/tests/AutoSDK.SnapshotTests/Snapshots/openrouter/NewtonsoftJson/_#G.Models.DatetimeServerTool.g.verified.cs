//HintName: G.Models.DatetimeServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenRouter built-in server tool: returns the current date and time
    /// </summary>
    public sealed partial class DatetimeServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatetimeServerToolTypeJsonConverter))]
        public global::G.DatetimeServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.DatetimeServerToolParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public DatetimeServerTool(
            global::G.DatetimeServerToolType type,
            global::G.DatetimeServerToolParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerTool" /> class.
        /// </summary>
        public DatetimeServerTool()
        {
        }
    }
}