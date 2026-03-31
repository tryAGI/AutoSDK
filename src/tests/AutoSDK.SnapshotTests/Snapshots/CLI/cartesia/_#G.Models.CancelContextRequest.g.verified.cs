//HintName: G.Models.CancelContextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelContextRequest
    {
        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// Whether to cancel the context, so that no more messages are generated for that context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Cancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelContextRequest" /> class.
        /// </summary>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        /// <param name="cancel">
        /// Whether to cancel the context, so that no more messages are generated for that context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelContextRequest(
            string contextId,
            bool cancel)
        {
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.Cancel = cancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelContextRequest" /> class.
        /// </summary>
        public CancelContextRequest()
        {
        }
    }
}