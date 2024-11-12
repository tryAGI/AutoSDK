//HintName: G.AccountClient.AccountUpdateAccountPWPolicy.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareAccountUpdateAccountPWPolicyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? accountId,
            ref bool? enforcePolicy,
            ref int? minLength,
            ref bool? requireChar,
            ref bool? requireUpper,
            ref bool? requireNumber,
            ref bool? requireSymbol,
            ref double? maxAgeInDays,
            ref bool? require2Auth,
            ref bool? relogin2Auth,
            ref int? idleTimeoutInMinutes);
        partial void PrepareAccountUpdateAccountPWPolicyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? accountId,
            bool? enforcePolicy,
            int? minLength,
            bool? requireChar,
            bool? requireUpper,
            bool? requireNumber,
            bool? requireSymbol,
            double? maxAgeInDays,
            bool? require2Auth,
            bool? relogin2Auth,
            int? idleTimeoutInMinutes);
        partial void ProcessAccountUpdateAccountPWPolicyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountUpdateAccountPWPolicyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateAccountPWPolicy.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="enforcePolicy"></param>
        /// <param name="minLength"></param>
        /// <param name="requireChar"></param>
        /// <param name="requireUpper"></param>
        /// <param name="requireNumber"></param>
        /// <param name="requireSymbol"></param>
        /// <param name="maxAgeInDays"></param>
        /// <param name="require2Auth"></param>
        /// <param name="relogin2Auth"></param>
        /// <param name="idleTimeoutInMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AccountVO> AccountUpdateAccountPWPolicyAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            bool? enforcePolicy = default,
            int? minLength = default,
            bool? requireChar = default,
            bool? requireUpper = default,
            bool? requireNumber = default,
            bool? requireSymbol = default,
            double? maxAgeInDays = default,
            bool? require2Auth = default,
            bool? relogin2Auth = default,
            int? idleTimeoutInMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAccountUpdateAccountPWPolicyArguments(
                httpClient: HttpClient,
                token: ref token,
                accountId: ref accountId,
                enforcePolicy: ref enforcePolicy,
                minLength: ref minLength,
                requireChar: ref requireChar,
                requireUpper: ref requireUpper,
                requireNumber: ref requireNumber,
                requireSymbol: ref requireSymbol,
                maxAgeInDays: ref maxAgeInDays,
                require2Auth: ref require2Auth,
                relogin2Auth: ref relogin2Auth,
                idleTimeoutInMinutes: ref idleTimeoutInMinutes);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/account/updateaccountpwpolicy",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("accountId", accountId?.ToString()) 
                .AddOptionalParameter("enforcePolicy", enforcePolicy?.ToString()) 
                .AddOptionalParameter("minLength", minLength?.ToString()) 
                .AddOptionalParameter("requireChar", requireChar?.ToString()) 
                .AddOptionalParameter("requireUpper", requireUpper?.ToString()) 
                .AddOptionalParameter("requireNumber", requireNumber?.ToString()) 
                .AddOptionalParameter("requireSymbol", requireSymbol?.ToString()) 
                .AddOptionalParameter("maxAgeInDays", maxAgeInDays?.ToString()) 
                .AddOptionalParameter("require2Auth", require2Auth?.ToString()) 
                .AddOptionalParameter("relogin2Auth", relogin2Auth?.ToString()) 
                .AddOptionalParameter("idleTimeoutInMinutes", idleTimeoutInMinutes?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAccountUpdateAccountPWPolicyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                accountId: accountId,
                enforcePolicy: enforcePolicy,
                minLength: minLength,
                requireChar: requireChar,
                requireUpper: requireUpper,
                requireNumber: requireNumber,
                requireSymbol: requireSymbol,
                maxAgeInDays: maxAgeInDays,
                require2Auth: require2Auth,
                relogin2Auth: relogin2Auth,
                idleTimeoutInMinutes: idleTimeoutInMinutes);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAccountUpdateAccountPWPolicyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_400)));
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_401)));
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAccountUpdateAccountPWPolicyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.AccountVO.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.AccountVO.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}