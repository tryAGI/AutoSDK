﻿//HintName: G.AbuseClient.GetAbuse.g.cs

#nullable enable

namespace G
{
    public partial class AbuseClient
    {
        partial void PrepareGetAbuseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ip);
        partial void PrepareGetAbuseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ip);
        partial void ProcessGetAbuseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAbuseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.<br/>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AbuseResponse> GetAbuseAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAbuseArguments(
                httpClient: HttpClient,
                ip: ref ip);

            var __pathBuilder = new PathBuilder(
                path: $"/{ip}/abuse",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAbuseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                ip: ip);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAbuseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetAbuseResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.AbuseResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}