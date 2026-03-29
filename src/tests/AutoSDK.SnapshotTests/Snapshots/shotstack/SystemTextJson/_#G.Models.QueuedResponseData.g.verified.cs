//HintName: G.Models.QueuedResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [QueuedResponse](#tocs_queuedresponse).
    /// </summary>
    public sealed partial class QueuedResponseData
    {
        /// <summary>
        /// Success response message or error details.<br/>
        /// Example: Render Successfully Queued
        /// </summary>
        /// <example>Render Successfully Queued</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The id of the render task in UUID format.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </summary>
        /// <example>2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedResponseData" /> class.
        /// </summary>
        /// <param name="message">
        /// Success response message or error details.<br/>
        /// Example: Render Successfully Queued
        /// </param>
        /// <param name="id">
        /// The id of the render task in UUID format.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueuedResponseData(
            string message,
            string id)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedResponseData" /> class.
        /// </summary>
        public QueuedResponseData()
        {
        }
    }
}