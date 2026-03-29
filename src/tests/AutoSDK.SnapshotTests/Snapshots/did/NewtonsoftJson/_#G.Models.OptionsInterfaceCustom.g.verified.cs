//HintName: G.Models.OptionsInterfaceCustom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptionsInterfaceCustom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_messages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsInterfaceCustom" /> class.
        /// </summary>
        /// <param name="maxMessages"></param>
        /// <param name="streaming"></param>
        /// <param name="description"></param>
        public OptionsInterfaceCustom(
            double? maxMessages,
            bool? streaming,
            string? description)
        {
            this.MaxMessages = maxMessages;
            this.Streaming = streaming;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsInterfaceCustom" /> class.
        /// </summary>
        public OptionsInterfaceCustom()
        {
        }
    }
}