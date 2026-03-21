//HintName: G.AgentsPlatformClient.TextSearch.g.cs

#nullable enable

namespace G
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareTextSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string textQuery,
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
            ref global::G.TextSearchConversationMessagesRouteSummaryMode? summaryMode,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            ref string? branchId,
            ref string? cursor,
            ref string? xiApiKey);
        partial void PrepareTextSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string textQuery,
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
            global::G.TextSearchConversationMessagesRouteSummaryMode? summaryMode,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            string? branchId,
            string? cursor,
            string? xiApiKey);
        partial void ProcessTextSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text Search Conversation Messages<br/>
        /// Search through conversation transcript messages by full-text and fuzzy search
        /// </summary>
        /// <param name="textQuery">
        /// The search query text for full-text and fuzzy matching
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
        /// Number of results per page. Max 50.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="summaryMode">
        /// Whether to include transcript summaries in the response.<br/>
        /// Default Value: exclude
        /// </param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MessagesSearchResponse> TextSearchAsync(
            string textQuery,
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
            global::G.TextSearchConversationMessagesRouteSummaryMode? summaryMode = default,
            global::G.ConversationInitiationSource? conversationInitiationSource = default,
            string? branchId = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTextSearchArguments(
                httpClient: HttpClient,
                textQuery: ref textQuery,
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
                conversationInitiationSource: conversationInitiationSource,
                branchId: ref branchId,
                cursor: ref cursor,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/convai/conversations/messages/text-search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("text_query", textQuery)
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("call_successful", callSuccessful?.ToString())
                .AddOptionalParameter("call_start_before_unix", callStartBeforeUnix?.ToString())
                .AddOptionalParameter("call_start_after_unix", callStartAfterUnix?.ToString())
                .AddOptionalParameter("call_duration_min_secs", callDurationMinSecs?.ToString())
                .AddOptionalParameter("call_duration_max_secs", callDurationMaxSecs?.ToString())
                .AddOptionalParameter("rating_max", ratingMax?.ToString())
                .AddOptionalParameter("rating_min", ratingMin?.ToString())
                .AddOptionalParameter("has_feedback_comment", hasFeedbackComment?.ToString().ToLowerInvariant())
                .AddOptionalParameter("user_id", userId)
                .AddOptionalParameter("evaluation_params", evaluationParams?.ToString())
                .AddOptionalParameter("data_collection_params", dataCollectionParams?.ToString())
                .AddOptionalParameter("tool_names", toolNames?.ToString())
                .AddOptionalParameter("main_languages", mainLanguages?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("summary_mode", summaryMode?.ToValueString())
                .AddOptionalParameter("conversation_initiation_source", conversationInitiationSource?.ToString())
                .AddOptionalParameter("branch_id", branchId)
                .AddOptionalParameter("cursor", cursor) 
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
            PrepareTextSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                textQuery: textQuery,
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
                conversationInitiationSource: conversationInitiationSource,
                branchId: branchId,
                cursor: cursor,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTextSearchResponse(
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
                ProcessTextSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.MessagesSearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.MessagesSearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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