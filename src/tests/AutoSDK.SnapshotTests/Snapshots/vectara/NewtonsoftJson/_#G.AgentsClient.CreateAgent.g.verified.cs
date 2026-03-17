//HintName: G.AgentsClient.CreateAgent.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareCreateAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.CreateAgentRequest request);
        partial void PrepareCreateAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.CreateAgentRequest request);
        partial void ProcessCreateAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAgentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create agent<br/>
        /// Create a new agent. An agent is compromised as 3 main things of functionality:<br/>
        ///   1. The **instructions** an agent follows. Known as a system in prompt in other platforms.<br/>
        ///   2. The **steps** an agent follows when receiving an input.<br/>
        ///   3. The **tools** an agent can use to resolve those steps and instructions.<br/>
        /// Instructions are tied to each step, and should be precisely crafted so that the agent can perform the desired actions when given an input. <br/>
        /// :::tip Creating more precise instructions<br/>
        /// Be specific to exactly what you want the agent to do. For emphasis, use CAPS if you want the agent to follow a specific format. Negative prompts also help with precision such as saying **DO NOT DO THIS**.<br/>
        /// :::<br/>
        /// To use an agent, create a new session (called thread or chat in other platforms), and send new inputs to the agent to get responses.<br/>
        /// :::note<br/>
        /// Only a single step is supported with no follow up steps. So the `first_step` will be only the only step. We will add multiple steps and step types to execute complex workflows, but many agents can work well with a single step.<br/>
        /// :::<br/>
        /// ## LLM configuration<br/>
        /// Agents use LLMs for reasoning and response generation. You can configure the following:<br/>
        /// - **Model**: Choose from available models like GPT-4o.<br/>
        /// - **Parameters**: Adjust temperature, max tokens, and other model-specific settings.<br/>
        /// - **Cost optimization**: Balance performance with token usage.<br/>
        /// - **Retry configuration**: Configure automatic retry behavior for transient failures.<br/>
        /// ## Using retries to improve user experience<br/>
        /// When agents interact with LLMs, transient failures like network interruptions can disrupt communication between the agent and the LLM. You can configure your agent to resume disrupted communication to ensure a smooth user experience.<br/>
        /// - `max_retries`: After an error, the agent will retry its request to the LLM this many times.<br/>
        /// - `initial_backoff_ms`: This is how many milliseconds the agent will wait before retrying, to give the cause of the error time to resolve.<br/>
        /// - `backoff_factor`: Every time the agent retries, it can multiply the last retry delay by this number, increasing the wait between retries. This is like giving a toddler a longer and longer timeout if it continues to misbehave.<br/>
        /// - `max_backoff_ms`: The maximum time you want the agent to wait between retries, so the backoff_factor does not create an unreasonably long delay for your users.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Agent> CreateAgentAsync(

            global::G.CreateAgentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAgentArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/agents",
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

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
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
            PrepareCreateAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateAgentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Agent creation request was malformed or contains invalid references.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
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
            // Permissions do not allow creating agents.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
                ProcessCreateAgentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Agent.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Agent.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create agent<br/>
        /// Create a new agent. An agent is compromised as 3 main things of functionality:<br/>
        ///   1. The **instructions** an agent follows. Known as a system in prompt in other platforms.<br/>
        ///   2. The **steps** an agent follows when receiving an input.<br/>
        ///   3. The **tools** an agent can use to resolve those steps and instructions.<br/>
        /// Instructions are tied to each step, and should be precisely crafted so that the agent can perform the desired actions when given an input. <br/>
        /// :::tip Creating more precise instructions<br/>
        /// Be specific to exactly what you want the agent to do. For emphasis, use CAPS if you want the agent to follow a specific format. Negative prompts also help with precision such as saying **DO NOT DO THIS**.<br/>
        /// :::<br/>
        /// To use an agent, create a new session (called thread or chat in other platforms), and send new inputs to the agent to get responses.<br/>
        /// :::note<br/>
        /// Only a single step is supported with no follow up steps. So the `first_step` will be only the only step. We will add multiple steps and step types to execute complex workflows, but many agents can work well with a single step.<br/>
        /// :::<br/>
        /// ## LLM configuration<br/>
        /// Agents use LLMs for reasoning and response generation. You can configure the following:<br/>
        /// - **Model**: Choose from available models like GPT-4o.<br/>
        /// - **Parameters**: Adjust temperature, max tokens, and other model-specific settings.<br/>
        /// - **Cost optimization**: Balance performance with token usage.<br/>
        /// - **Retry configuration**: Configure automatic retry behavior for transient failures.<br/>
        /// ## Using retries to improve user experience<br/>
        /// When agents interact with LLMs, transient failures like network interruptions can disrupt communication between the agent and the LLM. You can configure your agent to resume disrupted communication to ensure a smooth user experience.<br/>
        /// - `max_retries`: After an error, the agent will retry its request to the LLM this many times.<br/>
        /// - `initial_backoff_ms`: This is how many milliseconds the agent will wait before retrying, to give the cause of the error time to resolve.<br/>
        /// - `backoff_factor`: Every time the agent retries, it can multiply the last retry delay by this number, increasing the wait between retries. This is like giving a toddler a longer and longer timeout if it continues to misbehave.<br/>
        /// - `max_backoff_ms`: The maximum time you want the agent to wait between retries, so the backoff_factor does not create an unreasonably long delay for your users.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is the AgentToolConfiguration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </param>
        /// <param name="firstStepName">
        /// Name of a step in the steps map to use as the entry point. This is the preferred<br/>
        /// way to define the entry point - define all steps in the steps map and reference<br/>
        /// the entry point by name here.<br/>
        /// Example: classifier
        /// </param>
        /// <param name="steps">
        /// A map of named steps keyed by step name.<br/>
        /// Steps can transition to other steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Default Value: {}<br/>
        /// Example: {"department":"customer_service","version":"1.0.0","owner":"support-team"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="compaction">
        /// Configuration for automatic context compaction.
        /// </param>
        /// <param name="toolOutputOffloading">
        /// Configuration for offloading large tool outputs to artifacts.<br/>
        /// When tools produce outputs exceeding the size threshold, the output is stored<br/>
        /// as an artifact and replaced with a compact reference. The agent can then use<br/>
        /// artifact_read or artifact_grep to access the full content on demand.<br/>
        /// All fields are optional; omitted fields use model-inferred defaults.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Agent> CreateAgentAsync(
            string name,
            object toolConfigurations,
            global::G.AgentModel model,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? skills = default,
            global::G.FirstAgentStep? firstStep = default,
            string? firstStepName = default,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentStep>? steps = default,
            object? metadata = default,
            bool? enabled = default,
            global::G.CompactionConfig? compaction = default,
            global::G.ToolOutputOffloadingConfiguration? toolOutputOffloading = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateAgentRequest
            {
                Key = key,
                Name = name,
                Description = description,
                ToolConfigurations = toolConfigurations,
                Skills = skills,
                Model = model,
                FirstStep = firstStep,
                FirstStepName = firstStepName,
                Steps = steps,
                Metadata = metadata,
                Enabled = enabled,
                Compaction = compaction,
                ToolOutputOffloading = toolOutputOffloading,
            };

            return await CreateAgentAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}