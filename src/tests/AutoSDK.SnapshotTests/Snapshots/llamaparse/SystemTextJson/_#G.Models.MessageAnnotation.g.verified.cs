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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAnnotation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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