//HintName: G.Models.ScrapeResponseDataActionsJavascriptReturn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeResponseDataActionsJavascriptReturn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataActionsJavascriptReturn" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public ScrapeResponseDataActionsJavascriptReturn(
            string? type,
            object? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataActionsJavascriptReturn" /> class.
        /// </summary>
        public ScrapeResponseDataActionsJavascriptReturn()
        {
        }
    }
}