//HintName: G.Models.WatchNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WatchNamespaceModelResponse contains the state of a model.
    /// </summary>
    public sealed partial class WatchNamespaceModelResponse
    {
        /// <summary>
        /// State.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StateJsonConverter))]
        public global::G.State? State { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="state">
        /// State.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="message">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatchNamespaceModelResponse(
            global::G.State? state,
            string? message)
        {
            this.State = state;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchNamespaceModelResponse" /> class.
        /// </summary>
        public WatchNamespaceModelResponse()
        {
        }
    }
}