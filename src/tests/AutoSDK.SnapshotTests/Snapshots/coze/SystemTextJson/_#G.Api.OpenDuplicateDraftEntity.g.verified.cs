//HintName: G.Api.OpenDuplicateDraftEntity.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenDuplicateDraftEntitySecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenDuplicateDraftEntitySecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenDuplicateDraftEntitySecurityRequirement0,
            };
        partial void PrepareOpenDuplicateDraftEntityArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OpenDuplicateDraftEntityRequest request);
        partial void PrepareOpenDuplicateDraftEntityRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OpenDuplicateDraftEntityRequest request);
        partial void ProcessOpenDuplicateDraftEntityResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenDuplicateDraftEntityResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 复制资源<br/>
        /// {"0":{"ops":[{"insert":"复制智能体、扣子应用和工作流。\n"},{"attributes":{"anchor":"e8cfe53b","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"本 API 支持"},{"attributes":{"bold":"true"},"insert":"同工作空间复制"},{"insert":"或"},{"attributes":{"bold":"true"},"insert":"跨工作空间复制"},{"insert":"。如果你是空间成员，你可以调用本 API 将工作空间内任意智能体、扣子应用和工作流，复制到本空间或同一企业/团队下的其他已加入的工作空间。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"跨空间复制智能体或应用成功后，为保证正常运行，智能体和应用所使用的工作流、插件等资源也将同时复制到新空间。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"该 API 分为同步执行和异步执行，扣子根据不同资源复制类型自动采用对应的执行方式，具体说明如下：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"aceTable":"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c cs37vpaznrjdwdkztp9gl4p3ajuavptmar"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"0f133891","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"不支持将个人工作空间中的资源复制到企业或团队工作空间中，个人版工作空间中的资源只能复制到本空间。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"操作者需要加入源工作空间和目标工作空间。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"复制后的智能体或扣子应用为草稿状态。\n"}],"zoneId":"0","zoneType":"Z"},"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c":{"ops":[{"attributes":{},"insert":{"id":"r19qt9v1qzu0mg0epi4plzd2pu5j4bf6mi"}},{"attributes":{},"insert":{"id":"r1bh2obvla1g8ccpl3j8s043cd2b9kegdh"}},{"attributes":{},"insert":{"id":"r1yv6gau5df6t3ly9zb1ivylzmqrfg18ja"}}],"zoneId":"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c","zoneType":"R"},"cs37vpaznrjdwdkztp9gl4p3ajuavptmar":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"c1in7wpdp0r5jbiult938ogm712ufruk5t"}},{"attributes":{"colWidth":"336"},"insert":{"id":"c1veg2wg29a574pzw5k40naqrjyjqfyfvv"}},{"attributes":{"colWidth":"497"},"insert":{"id":"c1gmu2zjml0ykfyvbet45zdp68pu8hvm2d"}}],"zoneId":"cs37vpaznrjdwdkztp9gl4p3ajuavptmar","zoneType":"C"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"attributes":{"bold":"true"},"insert":"执行模式"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"attributes":{"bold":"true"},"insert":"适用场景"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"attributes":{"bold":"true"},"insert":"结果返回方式"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"insert":"同步执行\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"insert":"同一工作空间内复制"},{"attributes":{"bold":"true"},"insert":"智能体"},{"insert":"。\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"insert":"API 直接返回复制后的智能体 ID。\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"insert":"异步执行\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"同一工作空间内复制"},{"attributes":{"bold":"true"},"insert":"扣子应用"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"工作流"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"跨工作空间复制"},{"attributes":{"bold":"true"},"insert":"智能体"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"扣子应用"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"工作流"},{"insert":"。\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"insert":"API 返回任务 ID（"},{"attributes":{"inlineCode":"true"},"insert":"task_id"},{"insert":"），需要通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/query_resource_copy_execution_result\",\"linkId\":\"hWFInXcZNq\"}"},"insert":"查询资源复制的结果"},{"insert":"  API 查询执行结果。\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenDuplicateDraftEntityResponse> OpenDuplicateDraftEntityAsync(

            global::G.OpenDuplicateDraftEntityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenDuplicateDraftEntityArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenDuplicateDraftEntitySecurityRequirements,
                operationName: "OpenDuplicateDraftEntityAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/entities/copy_tasks",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareOpenDuplicateDraftEntityRequest(
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
            ProcessOpenDuplicateDraftEntityResponse(
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
                ProcessOpenDuplicateDraftEntityResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenDuplicateDraftEntityResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenDuplicateDraftEntityResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 复制资源<br/>
        /// {"0":{"ops":[{"insert":"复制智能体、扣子应用和工作流。\n"},{"attributes":{"anchor":"e8cfe53b","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"本 API 支持"},{"attributes":{"bold":"true"},"insert":"同工作空间复制"},{"insert":"或"},{"attributes":{"bold":"true"},"insert":"跨工作空间复制"},{"insert":"。如果你是空间成员，你可以调用本 API 将工作空间内任意智能体、扣子应用和工作流，复制到本空间或同一企业/团队下的其他已加入的工作空间。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"跨空间复制智能体或应用成功后，为保证正常运行，智能体和应用所使用的工作流、插件等资源也将同时复制到新空间。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"该 API 分为同步执行和异步执行，扣子根据不同资源复制类型自动采用对应的执行方式，具体说明如下：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"aceTable":"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c cs37vpaznrjdwdkztp9gl4p3ajuavptmar"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"0f133891","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"不支持将个人工作空间中的资源复制到企业或团队工作空间中，个人版工作空间中的资源只能复制到本空间。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"操作者需要加入源工作空间和目标工作空间。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"复制后的智能体或扣子应用为草稿状态。\n"}],"zoneId":"0","zoneType":"Z"},"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c":{"ops":[{"attributes":{},"insert":{"id":"r19qt9v1qzu0mg0epi4plzd2pu5j4bf6mi"}},{"attributes":{},"insert":{"id":"r1bh2obvla1g8ccpl3j8s043cd2b9kegdh"}},{"attributes":{},"insert":{"id":"r1yv6gau5df6t3ly9zb1ivylzmqrfg18ja"}}],"zoneId":"rs8vo4j1zca5dj5acmvhs504ypcaf9ii1c","zoneType":"R"},"cs37vpaznrjdwdkztp9gl4p3ajuavptmar":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"c1in7wpdp0r5jbiult938ogm712ufruk5t"}},{"attributes":{"colWidth":"336"},"insert":{"id":"c1veg2wg29a574pzw5k40naqrjyjqfyfvv"}},{"attributes":{"colWidth":"497"},"insert":{"id":"c1gmu2zjml0ykfyvbet45zdp68pu8hvm2d"}}],"zoneId":"cs37vpaznrjdwdkztp9gl4p3ajuavptmar","zoneType":"C"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"attributes":{"bold":"true"},"insert":"执行模式"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"attributes":{"bold":"true"},"insert":"适用场景"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"attributes":{"bold":"true"},"insert":"结果返回方式"},{"insert":"\n"}],"zoneId":"xr19qt9v1qzu0mg0epi4plzd2pu5j4bf6mixc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"insert":"同步执行\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"insert":"同一工作空间内复制"},{"attributes":{"bold":"true"},"insert":"智能体"},{"insert":"。\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"insert":"API 直接返回复制后的智能体 ID。\n"}],"zoneId":"xr1bh2obvla1g8ccpl3j8s043cd2b9kegdhxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1in7wpdp0r5jbiult938ogm712ufruk5t":{"ops":[{"insert":"异步执行\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1in7wpdp0r5jbiult938ogm712ufruk5t","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1veg2wg29a574pzw5k40naqrjyjqfyfvv":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"同一工作空间内复制"},{"attributes":{"bold":"true"},"insert":"扣子应用"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"工作流"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"跨工作空间复制"},{"attributes":{"bold":"true"},"insert":"智能体"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"扣子应用"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"工作流"},{"insert":"。\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1veg2wg29a574pzw5k40naqrjyjqfyfvv","zoneType":"Z"},"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d":{"ops":[{"insert":"API 返回任务 ID（"},{"attributes":{"inlineCode":"true"},"insert":"task_id"},{"insert":"），需要通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/query_resource_copy_execution_result\",\"linkId\":\"hWFInXcZNq\"}"},"insert":"查询资源复制的结果"},{"insert":"  API 查询执行结果。\n"}],"zoneId":"xr1yv6gau5df6t3ly9zb1ivylzmqrfg18jaxc1gmu2zjml0ykfyvbet45zdp68pu8hvm2d","zoneType":"Z"}}
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="toWorkspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenDuplicateDraftEntityResponse> OpenDuplicateDraftEntityAsync(
            string? entityId = default,
            global::G.TaskEntityType? entityType = default,
            string? toWorkspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenDuplicateDraftEntityRequest
            {
                EntityId = entityId,
                EntityType = entityType,
                ToWorkspaceId = toWorkspaceId,
            };

            return await OpenDuplicateDraftEntityAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}