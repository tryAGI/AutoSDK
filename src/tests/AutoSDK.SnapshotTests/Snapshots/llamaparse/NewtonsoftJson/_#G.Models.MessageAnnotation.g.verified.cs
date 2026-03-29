//HintName: G.Models.MessageAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAnnotation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        public MessageAnnotation(
            string type,
            string data,
            string? className)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAnnotation" /> class.
        /// </summary>
        public MessageAnnotation()
        {
        }
    }
}