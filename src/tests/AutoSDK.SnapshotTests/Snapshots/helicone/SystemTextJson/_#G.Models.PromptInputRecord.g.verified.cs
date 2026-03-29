//HintName: G.Models.PromptInputRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptInputRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_row_id")]
        public string? DatasetRowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_prompt_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> AutoPromptInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInputRecord" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="sourceRequest"></param>
        /// <param name="promptVersion"></param>
        /// <param name="createdAt"></param>
        /// <param name="autoPromptInputs"></param>
        /// <param name="datasetRowId"></param>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptInputRecord(
            string id,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string sourceRequest,
            string promptVersion,
            string createdAt,
            global::System.Collections.Generic.IList<object> autoPromptInputs,
            string? datasetRowId,
            string? responseBody,
            string? requestBody)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.DatasetRowId = datasetRowId;
            this.SourceRequest = sourceRequest ?? throw new global::System.ArgumentNullException(nameof(sourceRequest));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ResponseBody = responseBody;
            this.RequestBody = requestBody;
            this.AutoPromptInputs = autoPromptInputs ?? throw new global::System.ArgumentNullException(nameof(autoPromptInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInputRecord" /> class.
        /// </summary>
        public PromptInputRecord()
        {
        }
    }
}