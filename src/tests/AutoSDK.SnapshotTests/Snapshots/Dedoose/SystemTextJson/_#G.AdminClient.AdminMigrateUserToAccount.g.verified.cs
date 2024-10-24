﻿//HintName: G.AdminClient.AdminMigrateUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminMigrateUserToAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userToBeMovedId,
            ref global::System.Guid? accountIdToMoveTo);
        partial void PrepareAdminMigrateUserToAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userToBeMovedId,
            global::System.Guid? accountIdToMoveTo);
        partial void ProcessAdminMigrateUserToAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminMigrateUserToAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// MigrateUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AdminMigrateUserToAccountAsync(
            string? token = default,
            global::System.Guid? userToBeMovedId = default,
            global::System.Guid? accountIdToMoveTo = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAdminMigrateUserToAccountArguments(
                httpClient: HttpClient,
                token: ref token,
                userToBeMovedId: ref userToBeMovedId,
                accountIdToMoveTo: ref accountIdToMoveTo);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/admin/migrateusertoaccount",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userToBeMovedId", userToBeMovedId?.ToString()) 
                .AddOptionalParameter("accountIdToMoveTo", accountIdToMoveTo?.ToString()) 
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
            PrepareAdminMigrateUserToAccountRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                userToBeMovedId: userToBeMovedId,
                accountIdToMoveTo: accountIdToMoveTo);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAdminMigrateUserToAccountResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAdminMigrateUserToAccountResponseContent(
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

            return __content;
        }
    }
}