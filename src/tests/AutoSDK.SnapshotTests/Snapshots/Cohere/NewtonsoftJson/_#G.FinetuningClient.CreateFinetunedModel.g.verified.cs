//HintName: G.FinetuningClient.CreateFinetunedModel.g.cs

#nullable enable

namespace G
{
    public partial class FinetuningClient
    {
        partial void PrepareCreateFinetunedModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.FinetunedModel request);
        partial void PrepareCreateFinetunedModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.FinetunedModel request);
        partial void ProcessCreateFinetunedModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFinetunedModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            global::G.FinetunedModel request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFinetunedModelArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/finetuning/finetuned-models", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFinetunedModelRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFinetunedModelResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFinetunedModelResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateFinetunedModelResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="id">
        /// read-only. FinetunedModel ID.
        /// </param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="creatorId">
        /// read-only. User ID of the creator.
        /// </param>
        /// <param name="organizationId">
        /// read-only. Organization ID.
        /// </param>
        /// <param name="settings">
        /// The configuration used for fine-tuning.
        /// </param>
        /// <param name="status">
        /// The possible stages of a fine-tuned model life-cycle.<br/>
        ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
        ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
        ///  - STATUS_DEPLOYING_API: The fine-tuned model is being deployed.<br/>
        ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
        ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
        ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
        ///  - STATUS_TEMPORARILY_OFFLINE: The fine-tuned model is temporarily unavailable.<br/>
        ///  - STATUS_PAUSED: The fine-tuned model is paused (Vanilla only).<br/>
        ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </param>
        /// <param name="createdAt">
        /// read-only. Creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// read-only. Latest update timestamp.
        /// </param>
        /// <param name="completedAt">
        /// read-only. Timestamp for the completed fine-tuning.
        /// </param>
        /// <param name="lastUsed">
        /// read-only. Timestamp for the latest request to this fine-tuned model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            string name,
            global::G.Settings settings,
            string? xClientName = default,
            string? id = default,
            string? creatorId = default,
            string? organizationId = default,
            global::G.Status? status = global::G.Status.STATUSUNSPECIFIED,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            global::System.DateTime? completedAt = default,
            global::System.DateTime? lastUsed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FinetunedModel
            {
                Id = id,
                Name = name,
                CreatorId = creatorId,
                OrganizationId = organizationId,
                Settings = settings,
                Status = status,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                CompletedAt = completedAt,
                LastUsed = lastUsed,
            };

            return await CreateFinetunedModelAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}