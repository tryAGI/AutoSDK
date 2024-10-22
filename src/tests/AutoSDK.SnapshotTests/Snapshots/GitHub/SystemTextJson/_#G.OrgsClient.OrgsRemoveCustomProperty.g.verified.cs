//HintName: G.OrgsClient.OrgsRemoveCustomProperty.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsRemoveCustomPropertyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string customPropertyName);
        partial void PrepareOrgsRemoveCustomPropertyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string customPropertyName);
        partial void ProcessOrgsRemoveCustomPropertyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsRemoveCustomPropertyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove a custom property for an organization<br/>
        /// Removes a custom property that is defined for an organization.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsRemoveCustomPropertyAsync(
            string org,
            string customPropertyName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsRemoveCustomPropertyArguments(
                httpClient: HttpClient,
                org: ref org,
                customPropertyName: ref customPropertyName);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/schema/{customPropertyName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsRemoveCustomPropertyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                customPropertyName: customPropertyName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsRemoveCustomPropertyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsRemoveCustomPropertyResponseContent(
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
                global::G.BasicError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}