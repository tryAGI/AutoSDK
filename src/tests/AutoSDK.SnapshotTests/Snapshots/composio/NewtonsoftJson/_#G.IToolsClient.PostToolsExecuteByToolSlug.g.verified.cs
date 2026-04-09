//HintName: G.IToolsClient.PostToolsExecuteByToolSlug.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,

            global::G.PostToolsExecuteByToolSlugRequest request,
            string? xLlmGatewayHeaders = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="connectedAccountId">
        /// Unique identifier for the connected account to use for authentication<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="userId">
        /// User id for multi-user connected accounts (e.g. multiple users, organizations)<br/>
        /// Example: user-123
        /// </param>
        /// <param name="version">
        /// Tool version to execute (defaults to "00000000_00" if not specified)<br/>
        /// Example: latest
        /// </param>
        /// <param name="customAuthParams">
        /// Custom authentication parameters for tools that support parameterized authentication<br/>
        /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
        /// </param>
        /// <param name="customConnectionData">
        /// Custom connection data for tools that support custom connection data<br/>
        /// Example: {"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}
        /// </param>
        /// <param name="arguments">
        /// Key-value pairs of arguments required by the tool (mutually exclusive with text)<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="text">
        /// Natural language description of the task to perform (mutually exclusive with arguments)<br/>
        /// Example: Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,
            string? xLlmGatewayHeaders = default,
            string? connectedAccountId = default,
            string? userId = default,
            string? version = default,
            global::G.PostToolsExecuteByToolSlugRequestCustomAuthParams? customAuthParams = default,
            global::G.OneOf<global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>? customConnectionData = default,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            string? text = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}