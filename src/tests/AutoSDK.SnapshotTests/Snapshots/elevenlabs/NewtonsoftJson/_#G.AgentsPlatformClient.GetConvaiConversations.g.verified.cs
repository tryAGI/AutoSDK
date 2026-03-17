//HintName: G.AgentsPlatformClient.GetConvaiConversations.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareGetConvaiConversationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref string? agentId,
            global::G.EvaluationSuccessResult? callSuccessful,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            int? callDurationMinSecs,
            int? callDurationMaxSecs,
            int? ratingMax,
            int? ratingMin,
            bool? hasFeedbackComment,
            ref string? userId,
            global::System.Collections.Generic.IList<string>? evaluationParams,
            global::System.Collections.Generic.IList<string>? dataCollectionParams,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::System.Collections.Generic.IList<string>? mainLanguages,
            ref int? pageSize,
            ref global::G.GetConversationHistoriesRouteSummaryMode? summaryMode,
            ref string? search,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            ref string? branchId,
            ref string? xiApiKey);
        partial void PrepareGetConvaiConversationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            string? agentId,
            global::G.EvaluationSuccessResult? callSuccessful,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            int? callDurationMinSecs,
            int? callDurationMaxSecs,
            int? ratingMax,
            int? ratingMin,
            bool? hasFeedbackComment,
            string? userId,
            global::System.Collections.Generic.IList<string>? evaluationParams,
            global::System.Collections.Generic.IList<string>? dataCollectionParams,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::System.Collections.Generic.IList<string>? mainLanguages,
            int? pageSize,
            global::G.GetConversationHistoriesRouteSummaryMode? summaryMode,
            string? search,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            string? branchId,
            string? xiApiKey);
        partial void ProcessGetConvaiConversationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetConvaiConversationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Conversations<br/>
        /// Get all conversations of agents that user owns. With option to restrict to a specific agent.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="callSuccessful">
        /// The result of the success evaluation
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="callDurationMinSecs">
        /// Minimum call duration in seconds.
        /// </param>
        /// <param name="callDurationMaxSecs">
        /// Maximum call duration in seconds.
        /// </param>
        /// <param name="ratingMax">
        /// Maximum overall rating (1-5).
        /// </param>
        /// <param name="ratingMin">
        /// Minimum overall rating (1-5).
        /// </param>
        /// <param name="hasFeedbackComment">
        /// Filter conversations with user feedback comments.
        /// </param>
        /// <param name="userId">
        /// Filter conversations by the user ID who initiated them.
        /// </param>
        /// <param name="evaluationParams">
        /// Evaluation filters. Repeat param. Format: criteria_id:result. Example: eval=value_framing:success
        /// </param>
        /// <param name="dataCollectionParams">
        /// Data collection filters. Repeat param. Format: id:op:value where op is one of eq|neq|gt|gte|lt|lte|in|exists|missing. For in, pipe-delimit values.
        /// </param>
        /// <param name="toolNames">
        /// Filter conversations by tool names used during the call.
        /// </param>
        /// <param name="mainLanguages">
        /// Filter conversations by detected main language (language code).
        /// </param>
        /// <param name="pageSize">
        /// How many conversations to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="summaryMode">
        /// Whether to include transcript summaries in the response.<br/>
        /// Default Value: exclude
        /// </param>
        /// <param name="search">
        /// Full-text or fuzzy search over transcript messages
        /// </param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetConversationsPageResponseModel> GetConvaiConversationsAsync(
            string? cursor = default,
            string? agentId = default,
            global::G.EvaluationSuccessResult? callSuccessful = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            int? callDurationMinSecs = default,
            int? callDurationMaxSecs = default,
            int? ratingMax = default,
            int? ratingMin = default,
            bool? hasFeedbackComment = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? evaluationParams = default,
            global::System.Collections.Generic.IList<string>? dataCollectionParams = default,
            global::System.Collections.Generic.IList<string>? toolNames = default,
            global::System.Collections.Generic.IList<string>? mainLanguages = default,
            int? pageSize = default,
            global::G.GetConversationHistoriesRouteSummaryMode? summaryMode = default,
            string? search = default,
            global::G.ConversationInitiationSource? conversationInitiationSource = default,
            string? branchId = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetConvaiConversationsArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                agentId: ref agentId,
                callSuccessful: callSuccessful,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                callDurationMinSecs: callDurationMinSecs,
                callDurationMaxSecs: callDurationMaxSecs,
                ratingMax: ratingMax,
                ratingMin: ratingMin,
                hasFeedbackComment: hasFeedbackComment,
                userId: ref userId,
                evaluationParams: evaluationParams,
                dataCollectionParams: dataCollectionParams,
                toolNames: toolNames,
                mainLanguages: mainLanguages,
                pageSize: ref pageSize,
                summaryMode: ref summaryMode,
                search: ref search,
                conversationInitiationSource: conversationInitiationSource,
                branchId: ref branchId,
                xiApiKey: ref xiApiKey);

            var summaryModeValue = summaryMode switch
            {
                global::G.GetConversationHistoriesRouteSummaryMode.Exclude => "exclude",
                global::G.GetConversationHistoriesRouteSummaryMode.Include => "include",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/convai/conversations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("call_successful", callSuccessful?.ToString())
                .AddOptionalParameter("call_start_before_unix", callStartBeforeUnix?.ToString())
                .AddOptionalParameter("call_start_after_unix", callStartAfterUnix?.ToString())
                .AddOptionalParameter("call_duration_min_secs", callDurationMinSecs?.ToString())
                .AddOptionalParameter("call_duration_max_secs", callDurationMaxSecs?.ToString())
                .AddOptionalParameter("rating_max", ratingMax?.ToString())
                .AddOptionalParameter("rating_min", ratingMin?.ToString())
                .AddOptionalParameter("has_feedback_comment", hasFeedbackComment?.ToString())
                .AddOptionalParameter("user_id", userId)
                .AddOptionalParameter("evaluation_params", evaluationParams?.ToString())
                .AddOptionalParameter("data_collection_params", dataCollectionParams?.ToString())
                .AddOptionalParameter("tool_names", toolNames?.ToString())
                .AddOptionalParameter("main_languages", mainLanguages?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("summary_mode", summaryMode?.ToValueString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("conversation_initiation_source", conversationInitiationSource?.ToString())
                .AddOptionalParameter("branch_id", branchId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetConvaiConversationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cursor: cursor,
                agentId: agentId,
                callSuccessful: callSuccessful,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                callDurationMinSecs: callDurationMinSecs,
                callDurationMaxSecs: callDurationMaxSecs,
                ratingMax: ratingMax,
                ratingMin: ratingMin,
                hasFeedbackComment: hasFeedbackComment,
                userId: userId,
                evaluationParams: evaluationParams,
                dataCollectionParams: dataCollectionParams,
                toolNames: toolNames,
                mainLanguages: mainLanguages,
                pageSize: pageSize,
                summaryMode: summaryMode,
                search: search,
                conversationInitiationSource: conversationInitiationSource,
                branchId: branchId,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetConvaiConversationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetConvaiConversationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetConversationsPageResponseModel.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.GetConversationsPageResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}