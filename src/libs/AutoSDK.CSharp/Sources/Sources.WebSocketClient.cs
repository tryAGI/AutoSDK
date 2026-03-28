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
        var signatureParams = wsClient.QueryParameters.ToArray();
        var serializedParams = wsClient.SerializedQueryParameters.ToArray();

        if (signatureParams.Length == 0)
        {
            // No query parameters — simple ConnectAsync
            return $@"
        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            uri ??= new global::System.Uri(DefaultBaseUrl);

            await _clientWebSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
        }}";
        }

        // Generate typed ConnectAsync with query parameters
        var xmlDoc = new System.Text.StringBuilder();
        var parameterSignature = new System.Text.StringBuilder();
        var pathBuilderCalls = new System.Text.StringBuilder();

        xmlDoc.AppendLine("        /// <summary>");
        xmlDoc.AppendLine("        /// Connects to the WebSocket server with typed query parameters.");
        xmlDoc.AppendLine("        /// </summary>");

        // Method signature uses original (unserialized) parameters
        var isFirst = true;
        foreach (var param in signatureParams)
        {
            // XML doc for this parameter — collapse to single line
            var xmlSummary = !string.IsNullOrWhiteSpace(param.Description)
                ? param.Description.ClearForXml()
                : !string.IsNullOrWhiteSpace(param.Summary)
                    ? param.Summary.ClearForXml()
                    : string.Empty;

            if (!string.IsNullOrWhiteSpace(xmlSummary))
            {
                // Replace newlines with spaces to keep XML doc on one line
                xmlSummary = xmlSummary
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Trim();
                var xmlParamDoc = $"        /// <param name=\"{param.ParameterName}\">{xmlSummary}</param>";
                xmlDoc.AppendLine(xmlParamDoc);
            }

            // Parameter signature
            if (!isFirst)
            {
                parameterSignature.AppendLine(",");
            }
            isFirst = false;

            if (param.IsRequired)
            {
                var parameterDeclaration =
                    $"            {param.Type.CSharpTypeWithoutNullability} {param.ParameterName}";
                parameterSignature.Append(parameterDeclaration);
            }
            else
            {
                var parameterDeclaration =
                    $"            {param.Type.CSharpType} {param.ParameterName} = default";
                parameterSignature.Append(parameterDeclaration);
            }
        }

        xmlDoc.AppendLine("        /// <param name=\"uri\">Optional WebSocket endpoint override.</param>");
        xmlDoc.AppendLine("        /// <param name=\"cancellationToken\">A cancellation token.</param>");

        // PathBuilder uses serialized (expanded) parameters
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

        var hasRequired = signatureParams.Any(p => p.IsRequired);

        // Only generate simple overload when there are required params,
        // otherwise it's ambiguous with the typed overload (all optional)
        var simpleOverload = hasRequired ? $@"

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            uri ??= new global::System.Uri(DefaultBaseUrl);

            await _clientWebSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
        }}" : string.Empty;

        return $@"
{xmlDoc}        public async global::System.Threading.Tasks.Task ConnectAsync(
{parameterSignature},
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                path: uri?.ToString() ?? DefaultBaseUrl);
            __pathBuilder
{pathBuilderCalls}                ;
            var __path = __pathBuilder.ToString();

            await _clientWebSocket.ConnectAsync(
                new global::System.Uri(__path), cancellationToken).ConfigureAwait(false);
        }}{simpleOverload}";
    }
}
