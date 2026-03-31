//HintName: G.SessionsClient.SessionControllerCreate.g.cs

#nullable enable

namespace G
{
    public partial class SessionsClient
    {
        partial void PrepareSessionControllerCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateSessionDTO request);
        partial void PrepareSessionControllerCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateSessionDTO request);
        partial void ProcessSessionControllerCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSessionControllerCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Session> SessionControllerCreateAsync(

            global::G.CreateSessionDTO request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSessionControllerCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/session",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSessionControllerCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSessionControllerCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessSessionControllerCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Session.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Session.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="name">
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </param>
        /// <param name="squad">
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </param>
        /// <param name="messages">
        /// This is an array of chat messages in the session.
        /// </param>
        /// <param name="customer">
        /// This is the customer information associated with this session.
        /// </param>
        /// <param name="customerId">
        /// This is the customerId of the customer associated with this session.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the ID of the phone number associated with this session.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number configuration for this session.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Session> SessionControllerCreateAsync(
            string? name = default,
            global::G.CreateSessionDTOStatus? status = default,
            double? expirationSeconds = default,
            string? assistantId = default,
            global::G.CreateAssistantDTO? assistant = default,
            global::G.AssistantOverrides? assistantOverrides = default,
            string? squadId = default,
            global::G.CreateSquadDTO? squad = default,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages = default,
            global::G.CreateCustomerDTO? customer = default,
            string? customerId = default,
            string? phoneNumberId = default,
            global::G.ImportTwilioPhoneNumberDTO? phoneNumber = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateSessionDTO
            {
                Name = name,
                Status = status,
                ExpirationSeconds = expirationSeconds,
                AssistantId = assistantId,
                Assistant = assistant,
                AssistantOverrides = assistantOverrides,
                SquadId = squadId,
                Squad = squad,
                Messages = messages,
                Customer = customer,
                CustomerId = customerId,
                PhoneNumberId = phoneNumberId,
                PhoneNumber = phoneNumber,
            };

            return await SessionControllerCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}