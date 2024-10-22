//HintName: G.ProjectClient.ProjectAddProjectEncryptedByUser.g.cs

#nullable enable

namespace G
{
    public partial class ProjectClient
    {
        partial void PrepareProjectAddProjectEncryptedByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userId,
            ref string? title,
            ref string? decription,
            ref string? symKeyHash);
        partial void PrepareProjectAddProjectEncryptedByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userId,
            string? title,
            string? decription,
            string? symKeyHash);
        partial void ProcessProjectAddProjectEncryptedByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectAddProjectEncryptedByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddProjectEncryptedByUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="symKeyHash"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Project> ProjectAddProjectEncryptedByUserAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? title = default,
            string? decription = default,
            string? symKeyHash = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareProjectAddProjectEncryptedByUserArguments(
                httpClient: HttpClient,
                token: ref token,
                userId: ref userId,
                title: ref title,
                decription: ref decription,
                symKeyHash: ref symKeyHash);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/project/addprojectencryptedbyuser",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("decription", decription) 
                .AddOptionalParameter("symKeyHash", symKeyHash) 
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
            PrepareProjectAddProjectEncryptedByUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                userId: userId,
                title: title,
                decription: decription,
                symKeyHash: symKeyHash);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectAddProjectEncryptedByUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessProjectAddProjectEncryptedByUserResponseContent(
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
                global::G.Project.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}