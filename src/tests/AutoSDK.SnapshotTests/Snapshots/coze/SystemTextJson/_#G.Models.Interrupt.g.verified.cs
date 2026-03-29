//HintName: G.Models.Interrupt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Interrupt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 输入参数,输入节点需要
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? RequiredParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Interrupt" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="eventId"></param>
        /// <param name="requiredParameters">
        /// 输入参数,输入节点需要
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Interrupt(
            string? data,
            string? eventId,
            global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? requiredParameters,
            int? type)
        {
            this.Data = data;
            this.EventId = eventId;
            this.RequiredParameters = requiredParameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interrupt" /> class.
        /// </summary>
        public Interrupt()
        {
        }
    }
}