﻿//HintName: G.Api.EndPoints.Create_run_runs_post.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Create_run_runs_postAsync(
            RunCreateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/runs", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create Run
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="executionOrder"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="manifestId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="childRuns"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Create_run_runs_postAsync(
            string name,
            string runType,
            object? inputs = default,
            global::System.DateTime startTime = default,
            global::System.DateTime endTime = default,
            RunCreateSchemaExtendedExtra? extra = default,
            string? error = default,
            int executionOrder = default,
            RunCreateSchemaExtendedSerialized? serialized = default,
            object? outputs = default,
            string? parentRunId = default,
            string? manifestId = default,
            global::System.Collections.Generic.IList<RunCreateSchemaExtendedEvents?>? events = default,
            global::System.Collections.Generic.IList<string?>? tags = default,
            string? id = default,
            string? sessionId = default,
            string? sessionName = default,
            global::System.Collections.Generic.IList<RunCreateSchema>? childRuns = default,
            string? referenceExampleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RunCreateSchemaExtended
            {
                Name = name,
                Inputs = inputs,
                RunType = runType,
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Error = error,
                ExecutionOrder = executionOrder,
                Serialized = serialized,
                Outputs = outputs,
                ParentRunId = parentRunId,
                ManifestId = manifestId,
                Events = events,
                Tags = tags,
                Id = id,
                SessionId = sessionId,
                SessionName = sessionName,
                ChildRuns = childRuns,
                ReferenceExampleId = referenceExampleId,
            };

            await Create_run_runs_postAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}