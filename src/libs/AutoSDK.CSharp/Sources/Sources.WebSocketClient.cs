using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName WebSocketClient(
        WebSocketClient wsClient,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{wsClient.FileNameWithoutExtension}.g.cs",
            Text: GenerateWebSocketClient(wsClient));
    }

    public static string GenerateWebSocketClient(
        WebSocketClient wsClient)
    {
        var hasOptions = !wsClient.Settings.HasJsonSerializerContext();

        return $@"
#nullable enable

namespace {wsClient.Settings.Namespace}
{{
    {wsClient.Summary.ToXmlDocumentationSummary()}
    public sealed partial class {wsClient.ClassName} : global::System.IDisposable, global::System.IAsyncDisposable
    {{
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = ""{wsClient.BaseUrl}"";

        private readonly global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@"
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions {{ get; set; }} = new global::System.Text.Json.JsonSerializerOptions();" : $@"
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }} = global::{wsClient.Settings.JsonSerializerContext}.Default;")}

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the {wsClient.ClassName}.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name=""clientWebSocket"">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public {wsClient.ClassName}(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {{
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }}

{GenerateWebSocketAuthorizationConstructors(wsClient)}

{GenerateConnectAsync(wsClient)}

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (!IsConnected)
            {{
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }}

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (!IsConnected)
            {{
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _clientWebSocket.Dispose();
        }}

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {{
            if (IsConnected)
            {{
                try
                {{
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: ""Closing"",
                        cancellationToken: default).ConfigureAwait(false);
                }}
                catch (global::System.Net.WebSockets.WebSocketException)
                {{
                    // Ignore errors during dispose
                }}
            }}
            _clientWebSocket.Dispose();
        }}

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
        partial void OnReceiveException(
            global::System.Exception exception,
            ref bool rethrow);
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateWebSocketAuthorizationConstructors(WebSocketClient wsClient)
    {
        var result = new System.Text.StringBuilder();

        foreach (var auth in wsClient.Authorizations)
        {
            if (auth.Type == SecuritySchemeType.Http &&
                !string.Equals(auth.Scheme, "basic", StringComparison.OrdinalIgnoreCase))
            {
                var friendlyName = string.IsNullOrWhiteSpace(auth.FriendlyName)
                    ? auth.Scheme.ToPropertyName()
                    : auth.FriendlyName;
                var schemeName = string.IsNullOrWhiteSpace(auth.Scheme)
                    ? "Bearer"
                    : auth.Scheme;

                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using {schemeName} authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsing{friendlyName}(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader(""Authorization"", $""{schemeName} {{apiKey}}"");
        }}

        /// <summary>
        /// Creates a new instance with {schemeName} token authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        /// <param name=""clientWebSocket""></param>
        public {wsClient.ClassName}(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {{
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsing{friendlyName}(apiKey);

            Authorized(_clientWebSocket);
        }}";
                result.AppendLine(authorizationBlock);
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Header)
            {
                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using API key in header.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader(""{auth.Name}"", apiKey);
        }}

        /// <summary>
        /// Creates a new instance with API key header authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        /// <param name=""clientWebSocket""></param>
        public {wsClient.ClassName}(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {{
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_clientWebSocket);
        }}";
                result.AppendLine(authorizationBlock);
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Query)
            {
                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using API key in query parameter.
        /// The key will be appended to the URL during ConnectAsync.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            // Query parameter auth is handled during ConnectAsync
            _queryApiKey = apiKey;
            _queryApiKeyName = ""{auth.Name}"";
        }}

        private string? _queryApiKey;
        private string? _queryApiKeyName;";
                result.AppendLine(authorizationBlock);
            }
        }

        return result.ToString();
    }

    private static string GenerateConnectAsync(WebSocketClient wsClient)
    {
        var serverVariables = wsClient.ServerVariables.ToArray();
        var signatureParams = wsClient.QueryParameters.ToArray();
        var serializedParams = wsClient.SerializedQueryParameters.ToArray();
        var hasTypedParameters = serverVariables.Length > 0 || signatureParams.Length > 0;
        var hasRequiredParameters = serverVariables.Any(static x => x.IsRequired) || signatureParams.Any(static x => x.IsRequired);
        var supportsQueryApiKeyAuth = wsClient.Authorizations.Any(
            static x => x.Type == SecuritySchemeType.ApiKey &&
                        x.In == ParameterLocation.Query);
        var appendQueryApiKeyIfNeeded = supportsQueryApiKeyAuth
            ? @"
                if (_queryApiKey is not null && _queryApiKeyName is not null)
                {
                    __pathBuilder.AddRequiredParameter(_queryApiKeyName, _queryApiKey);
                }"
            : string.Empty;

        var connectionHelpers = @"
        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval)
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

            if (additionalHeaders is not null)
            {
                foreach (var header in additionalHeaders)
                {
                    _clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
                }
            }

            if (additionalSubProtocols is not null)
            {
                foreach (var subProtocol in additionalSubProtocols)
                {
                    _clientWebSocket.Options.AddSubProtocol(subProtocol);
                }
            }
        }

        private async global::System.Threading.Tasks.Task ConnectAsyncCore(
            global::System.Uri uri,
            global::System.TimeSpan? connectTimeout,
            global::System.Threading.CancellationToken cancellationToken)
        {
            global::System.Threading.CancellationTokenSource? __timeoutCancellationTokenSource = null;
            var __effectiveCancellationToken = cancellationToken;

            if (connectTimeout is not null)
            {
                __timeoutCancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                __timeoutCancellationTokenSource.CancelAfter(connectTimeout.Value);
                __effectiveCancellationToken = __timeoutCancellationTokenSource.Token;
            }

            try
            {
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }";

        if (!hasTypedParameters)
        {
            return $@"
{connectionHelpers}

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: DefaultBaseUrl);
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}";
        }

        var xmlDoc = new System.Text.StringBuilder();
        var parameterSignature = new System.Text.StringBuilder();
        var baseUrlReplacements = new System.Text.StringBuilder();
        var pathBuilderCalls = new System.Text.StringBuilder();

        xmlDoc.AppendLine("        /// <summary>");
        xmlDoc.AppendLine("        /// Connects to the WebSocket server with typed connection parameters.");
        xmlDoc.AppendLine("        /// </summary>");

        var isFirst = true;

        void AppendParameter(MethodParameter param, bool preferNonNullableDefaultType)
        {
            var xmlSummary = !string.IsNullOrWhiteSpace(param.Description)
                ? param.Description.ClearForXml()
                : !string.IsNullOrWhiteSpace(param.Summary)
                    ? param.Summary.ClearForXml()
                    : string.Empty;

            if (!string.IsNullOrWhiteSpace(xmlSummary))
            {
                xmlSummary = xmlSummary
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Trim();
                var xmlParamDoc = $"        /// <param name=\"{param.ParameterName}\">{xmlSummary}</param>";
                xmlDoc.AppendLine(xmlParamDoc);
            }

            if (!isFirst)
            {
                parameterSignature.AppendLine(",");
            }
            isFirst = false;

            if (param.IsRequired && !param.HasSchemaDefault)
            {
                var parameterDeclaration =
                    $"            {param.Type.CSharpTypeWithoutNullability} {param.ParameterName}";
                parameterSignature.Append(parameterDeclaration);
            }
            else
            {
                var parameterType = preferNonNullableDefaultType && param.HasSchemaDefault
                    ? param.Type.CSharpTypeWithoutNullability
                    : param.Type.CSharpType;
                var parameterDefaultValue = param.HasSchemaDefault
                    ? param.ParameterDefaultValue
                    : "default";
                var parameterDeclaration =
                    $"            {parameterType} {param.ParameterName} = {parameterDefaultValue}";
                parameterSignature.Append(parameterDeclaration);
            }
        }

        foreach (var param in serverVariables)
        {
            AppendParameter(param, preferNonNullableDefaultType: true);

            if (wsClient.BaseUrlTemplate.Contains("{" + param.Id + "}", StringComparison.Ordinal))
            {
                var replacementLine =
                    $"                __baseUrl = __baseUrl.Replace(\"{{{param.Id}}}\", global::System.Uri.EscapeDataString({param.ParameterName}));";
                baseUrlReplacements.AppendLine(replacementLine);
            }
            else
            {
                var pathBuilderCall =
                    $"                .AddRequiredParameter(\"{param.Id}\", {param.ParameterName})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
        }

        foreach (var param in signatureParams)
        {
            AppendParameter(param, preferNonNullableDefaultType: false);
        }

        xmlDoc.AppendLine("        /// <param name=\"uri\">Optional WebSocket endpoint override.</param>");
        xmlDoc.AppendLine("        /// <param name=\"additionalHeaders\">Additional headers applied before connecting.</param>");
        xmlDoc.AppendLine("        /// <param name=\"additionalSubProtocols\">Additional WebSocket subprotocols applied before connecting.</param>");
        xmlDoc.AppendLine("        /// <param name=\"keepAliveInterval\">Optional keep-alive interval.</param>");
        xmlDoc.AppendLine("        /// <param name=\"connectTimeout\">Optional connect timeout.</param>");
        xmlDoc.AppendLine("        /// <param name=\"cancellationToken\">A cancellation token.</param>");

        foreach (var param in serializedParams)
        {
            var additionalArguments = param.Type.IsArray
                ? $", delimiter: \"{param.Delimiter}\", explode: {(param.Explode ? "true" : "false")}"
                : string.Empty;
            if (param.Type.IsArray && param.Type.SubTypes[0].Unbox<TypeData>().CSharpTypeWithoutNullability is not "string")
            {
                additionalArguments = $", selector: static x => {param.Selector}" + additionalArguments;
            }

            if (param.IsRequired && !param.Type.IsNullable)
            {
                // For non-nullable required params, replace ?. with . since the type is non-nullable
                var value = param.Value.Replace("?.", ".");
                var pathBuilderCall =
                    $"                .AddRequiredParameter(\"{param.Id}\", {value}{additionalArguments})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
            else
            {
                var pathBuilderCall =
                    $"                .AddOptionalParameter(\"{param.Id}\", {param.Value}{additionalArguments})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
        }

        var templateConstant = !string.IsNullOrWhiteSpace(wsClient.BaseUrlTemplate)
            ? $@"

        private const string DefaultBaseUrlTemplate = {wsClient.BaseUrlTemplate.ToCSharpStringLiteral()};"
            : string.Empty;

        var simpleOverload = hasRequiredParameters ? $@"

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: DefaultBaseUrl);
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}" : string.Empty;

        var baseUrlSource = !string.IsNullOrWhiteSpace(wsClient.BaseUrlTemplate)
            ? "DefaultBaseUrlTemplate"
            : "DefaultBaseUrl";

        return $@"
{connectionHelpers}{templateConstant}
{simpleOverload}

{xmlDoc}        public async global::System.Threading.Tasks.Task ConnectAsync(
{parameterSignature},
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __baseUrl = {baseUrlSource};
{baseUrlReplacements}                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
{pathBuilderCalls}                ;
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}";
    }
}
