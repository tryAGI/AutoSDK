//HintName: G.Models.DatapointResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatapointResponse
    {
        /// <summary>
        /// Unique identifier for the datapoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatapointResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the datapoint.
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="target"></param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatapointResponse(
            string id,
            object? inputs,
            object? target,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs;
            this.Target = target;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatapointResponse" /> class.
        /// </summary>
        public DatapointResponse()
        {
        }
    }
}