//HintName: G.Models.CreateBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchRequest
    {
        /// <summary>
        /// List of individual call objects following the SendCall schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateBatchRequestCallObject> CallObjects { get; set; }

        /// <summary>
        /// Global properties applied to all calls unless overridden. Must include at least task or pathway_id. Must NOT include phone_number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Global { get; set; }

        /// <summary>
        /// Short label for the batch (max 60 chars, shown in dashboard)<br/>
        /// Default Value: Untitled Batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL receiving POST updates at each lifecycle phase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_webhook")]
        public string? StatusWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="callObjects">
        /// List of individual call objects following the SendCall schema
        /// </param>
        /// <param name="global">
        /// Global properties applied to all calls unless overridden. Must include at least task or pathway_id. Must NOT include phone_number.
        /// </param>
        /// <param name="description">
        /// Short label for the batch (max 60 chars, shown in dashboard)<br/>
        /// Default Value: Untitled Batch
        /// </param>
        /// <param name="statusWebhook">
        /// URL receiving POST updates at each lifecycle phase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchRequest(
            global::System.Collections.Generic.IList<global::G.CreateBatchRequestCallObject> callObjects,
            object global,
            string? description,
            string? statusWebhook)
        {
            this.CallObjects = callObjects ?? throw new global::System.ArgumentNullException(nameof(callObjects));
            this.Global = global ?? throw new global::System.ArgumentNullException(nameof(global));
            this.Description = description;
            this.StatusWebhook = statusWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        public CreateBatchRequest()
        {
        }
    }
}