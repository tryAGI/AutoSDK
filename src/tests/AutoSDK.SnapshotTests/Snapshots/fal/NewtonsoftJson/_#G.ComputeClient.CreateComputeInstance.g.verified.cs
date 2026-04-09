//HintName: G.ComputeClient.CreateComputeInstance.g.cs

#nullable enable

namespace G
{
    public partial class ComputeClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateComputeInstanceSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateComputeInstanceSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateComputeInstanceSecurityRequirement0,
            };
        partial void PrepareCreateComputeInstanceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? idempotencyKey,
            global::G.CreateComputeInstanceRequest request);
        partial void PrepareCreateComputeInstanceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? idempotencyKey,
            global::G.CreateComputeInstanceRequest request);
        partial void ProcessCreateComputeInstanceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateComputeInstanceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Compute Instance<br/>
        /// Creates a new compute instance with the specified configuration and SSH key.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Valid SSH public key required for instance access<br/>
        /// **Key Features:**<br/>
        /// - Create high-performance GPU instances<br/>
        /// - Specify sector for InfiniBand configuration (8x H100 only)<br/>
        /// - SSH key-based authentication<br/>
        /// - Automatic instance provisioning and region assignment<br/>
        /// - Idempotent creation with Idempotency-Key header (optional but recommended)<br/>
        /// **Common Use Cases:**<br/>
        /// - Spin up compute resources for ML training<br/>
        /// - Create GPU instances for inference workloads<br/>
        /// - Set up development environments with H100 GPUs<br/>
        /// - Deploy distributed training with InfiniBand networking<br/>
        /// **Instance Types:**<br/>
        /// - `gpu_8x_h100_sxm5`: 8x NVIDIA H100 GPUs (high-performance, supports sector configuration for InfiniBand)<br/>
        /// - `gpu_1x_h100_sxm5`: 1x NVIDIA H100 GPU (standard)<br/>
        /// **Idempotency:**<br/>
        /// - Optional Idempotency-Key header prevents duplicate instance creation on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateComputeInstanceResponse> CreateComputeInstanceAsync(

            global::G.CreateComputeInstanceRequest request,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateComputeInstanceArguments(
                httpClient: HttpClient,
                idempotencyKey: ref idempotencyKey,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateComputeInstanceSecurityRequirements,
                operationName: "CreateComputeInstanceAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/compute/instances",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            if (idempotencyKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Idempotency-Key", idempotencyKey.ToString());
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
            PrepareCreateComputeInstanceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                idempotencyKey: idempotencyKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateComputeInstanceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateComputeInstanceResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateComputeInstanceResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateComputeInstanceResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateComputeInstanceResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
            // Authentication required
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateComputeInstanceResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateComputeInstanceResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateComputeInstanceResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateComputeInstanceResponse3>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // Access denied
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.CreateComputeInstanceResponse4? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.CreateComputeInstanceResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.CreateComputeInstanceResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateComputeInstanceResponse4>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.CreateComputeInstanceResponse5? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.CreateComputeInstanceResponse5.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.CreateComputeInstanceResponse5.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateComputeInstanceResponse5>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.CreateComputeInstanceResponse6? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.CreateComputeInstanceResponse6.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.CreateComputeInstanceResponse6.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateComputeInstanceResponse6>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessCreateComputeInstanceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateComputeInstanceResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateComputeInstanceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Compute Instance<br/>
        /// Creates a new compute instance with the specified configuration and SSH key.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Valid SSH public key required for instance access<br/>
        /// **Key Features:**<br/>
        /// - Create high-performance GPU instances<br/>
        /// - Specify sector for InfiniBand configuration (8x H100 only)<br/>
        /// - SSH key-based authentication<br/>
        /// - Automatic instance provisioning and region assignment<br/>
        /// - Idempotent creation with Idempotency-Key header (optional but recommended)<br/>
        /// **Common Use Cases:**<br/>
        /// - Spin up compute resources for ML training<br/>
        /// - Create GPU instances for inference workloads<br/>
        /// - Set up development environments with H100 GPUs<br/>
        /// - Deploy distributed training with InfiniBand networking<br/>
        /// **Instance Types:**<br/>
        /// - `gpu_8x_h100_sxm5`: 8x NVIDIA H100 GPUs (high-performance, supports sector configuration for InfiniBand)<br/>
        /// - `gpu_1x_h100_sxm5`: 1x NVIDIA H100 GPU (standard)<br/>
        /// **Idempotency:**<br/>
        /// - Optional Idempotency-Key header prevents duplicate instance creation on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="instanceType">
        /// Type of compute instance to create<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </param>
        /// <param name="sshKey">
        /// SSH public key for accessing the instance (e.g., 'ssh-rsa AAAAB3...')<br/>
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQC... user@host
        /// </param>
        /// <param name="sector">
        /// Sector for InfiniBand configuration (only valid with gpu_8x_h100_sxm5)<br/>
        /// Example: sector_1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateComputeInstanceResponse> CreateComputeInstanceAsync(
            global::G.CreateComputeInstanceRequestInstanceType instanceType,
            string sshKey,
            string? idempotencyKey = default,
            global::G.CreateComputeInstanceRequestSector? sector = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateComputeInstanceRequest
            {
                InstanceType = instanceType,
                SshKey = sshKey,
                Sector = sector,
            };

            return await CreateComputeInstanceAsync(
                idempotencyKey: idempotencyKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}