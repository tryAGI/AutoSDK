//HintName: G.Models.FormatTextConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Plain text response format
    /// </summary>
    public sealed partial class FormatTextConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FormatTextConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTextConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        public FormatTextConfig(
            global::G.FormatTextConfigType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTextConfig" /> class.
        /// </summary>
        public FormatTextConfig()
        {
        }
    }
}