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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The id of the render task in UUID format.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </summary>
        /// <example>2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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