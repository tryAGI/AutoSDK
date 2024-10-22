//HintName: G.PersonalizedVideoClient.PersonalizedVideoAddContact.g.cs

#nullable enable

namespace G
{
    public partial class PersonalizedVideoClient
    {
        partial void PreparePersonalizedVideoAddContactArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PersonalizedVideoAddContactRequest request);
        partial void PreparePersonalizedVideoAddContactRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PersonalizedVideoAddContactRequest request);
        partial void ProcessPersonalizedVideoAddContactResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(
            global::G.PersonalizedVideoAddContactRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePersonalizedVideoAddContactArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/personalized_video/add_contact",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePersonalizedVideoAddContactRequest(
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
            ProcessPersonalizedVideoAddContactResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="projectId">
        /// Example: &lt;project_id&gt;
        /// </param>
        /// <param name="variablesList">
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(
            string? projectId = default,
            global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? variablesList = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PersonalizedVideoAddContactRequest
            {
                ProjectId = projectId,
                VariablesList = variablesList,
            };

            await PersonalizedVideoAddContactAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}