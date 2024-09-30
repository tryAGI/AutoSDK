using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateEndPoint(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return string.Empty;
        }

        var contentType = endPoint.ContentType switch
        {
            ContentType.String => "string",
            ContentType.Stream => "global::System.IO.Stream",
            _ => "byte[]",
        };
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    public partial class {endPoint.ClassName}
    {{
        partial void Prepare{endPoint.NotAsyncMethodName}Arguments(
            global::System.Net.Http.HttpClient httpClient{endPoint.Parameters
                .Where(x => x.Location != null)
                .Select(x => $@",
            {(x.Type.IsReferenceable ? "ref " : "")}{x.Type.CSharpType} {x.ParameterName}").Inject(emptyValue: "")}{
(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @$",
            {endPoint.RequestType.CSharpTypeWithoutNullability} request")});
        partial void Prepare{endPoint.NotAsyncMethodName}Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage{endPoint.Parameters
                .Where(x => x.Location != null)
                .Select(x => $@",
            {x.Type.CSharpType} {x.ParameterName}").Inject(emptyValue: "")}{
(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @$",
            {endPoint.RequestType.CSharpTypeWithoutNullability} request")});
        partial void Process{endPoint.NotAsyncMethodName}Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
{(string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType) || endPoint.Stream ? " " : $@"
        partial void Process{endPoint.NotAsyncMethodName}ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref {contentType} content);")}

{GenerateMethod(endPoint)}
{GenerateExtensionMethod(endPoint)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateEndPointInterface(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return string.Empty;
        }

        return $@"#nullable enable

namespace {endPoint.Namespace}
{{
    public partial interface I{endPoint.ClassName}
    {{
{GenerateMethod(endPoint, isInterface: true)}
{GenerateExtensionMethod(endPoint, isInterface: true)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GetHttpMethod(string targetFramework, OperationType operationType)
    {
        targetFramework = targetFramework ?? throw new ArgumentNullException(nameof(targetFramework));
        
        if (operationType == OperationType.Patch// &&
            //(targetFramework.StartsWith("net4", StringComparison.OrdinalIgnoreCase) ||
            //targetFramework.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase))
            )
        {
            return "new global::System.Net.Http.HttpMethod(\"PATCH\")";
        }
        
        return $"global::System.Net.Http.HttpMethod.{operationType:G}";
    }
    
    public static string GenerateMethod(
        EndPoint endPoint, bool isInterface = false)
    {
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType.CSharpTypeWithoutNullability}>";
        var httpCompletionOption = endPoint.Stream
            ? nameof(HttpCompletionOption.ResponseHeadersRead)
            : nameof(HttpCompletionOption.ResponseContentRead);
        var cancellationTokenAttribute = endPoint.Stream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var cancellationTokenInsideReadAsync = endPoint.Settings.TargetFramework.StartsWith("net8", StringComparison.OrdinalIgnoreCase)
            ? "cancellationToken"
            : string.Empty;
        var contentType = endPoint.ContentType switch
        {
            ContentType.String => "String",
            ContentType.Stream => "Stream",
            _ => "ByteArray",
        };
        var body = isInterface
            ? ";"
            : @$"
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) || endPoint.RequestType.IsAnyOfLike ? " " : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
            PrepareArguments(
                client: _httpClient);
            Prepare{endPoint.NotAsyncMethodName}Arguments(
                httpClient: _httpClient{endPoint.Parameters
                    .Where(x => x.Location != null)
                    .Select(x => $@",
                {x.ParameterName}: {(x.Type.IsReferenceable ? "ref " : "")}{x.ParameterName}").Inject(emptyValue: "")}{
                (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @",
                request: request")});
{(endPoint.Parameters.Any(x => x is { Location: ParameterLocation.Header }) ? "" : " ")}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: true })
    .Select(x => $@"
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum ? ".ToValueString()" : "")});").Inject()}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: false })
    .Select(x => $@"
            if ({x.ParameterName} != default)
            {{
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum ? "?.ToValueString() ?? string.Empty" : "")});
            }}").Inject()}

{(endPoint.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ? endPoint.Parameters
    .Where(x => x is { Location: not null, Type.EnumValues.Length: > 0 })
    .Select(x => $@"
            var {x.ArgumentName} = {x.ParameterName} switch
            {{
{x.Type.Properties.Zip(x.Type.EnumValues, (property, value) => (Property: property, Value: value))
    .Select(y => $@"
                {x.Type.CSharpTypeWithoutNullability}.{y.Property} => ""{y.Value}"",").Inject()}
                _ => throw new global::System.NotImplementedException(""Enum value not implemented.""),
            }};").Inject() : " ")}
{GeneratePathAndQuery(endPoint)}
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: {GetHttpMethod(endPoint.Settings.TargetFramework, endPoint.HttpMethod)},
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
{GenerateRequestData(endPoint)}

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            Prepare{endPoint.NotAsyncMethodName}Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest{endPoint.Parameters
                    .Where(x => x.Location != null)
                    .Select(x => $@",
                {x.ParameterName}: {x.ParameterName}").Inject(emptyValue: "")}{
                (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @",
                request: request")});

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.{httpCompletionOption},
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            Process{endPoint.NotAsyncMethodName}Response(
                httpClient: _httpClient,
                httpResponseMessage: response);
{(string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType) || endPoint.Stream ? @" 
            response.EnsureSuccessStatusCode();
 " : $@"
            var __content = await response.Content.ReadAs{contentType}Async({cancellationTokenInsideReadAsync}).ConfigureAwait(false);

{(endPoint.ContentType == ContentType.String ? @" 
            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);" : " ")}
            Process{endPoint.NotAsyncMethodName}ResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

{(endPoint.ContentType == ContentType.String ? @" 
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }" : @"
            response.EnsureSuccessStatusCode();")}

{(endPoint.ContentType == ContentType.String && endPoint.ResponseType.CSharpTypeWithoutNullability is not "string" ? $@" 
            return
                {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.Settings.JsonSerializerContext)} ??
                throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");" : @" 
            return __content;")}")}
{(endPoint.Stream ? $@"
            using var stream = await response.Content.ReadAsStreamAsync({cancellationTokenInsideReadAsync}).ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {{
                var __content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.Settings.JsonSerializerContext)} ??
                                       throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");

                yield return streamedResponse;
            }}" : " ")}
        }}";
        
        return $@" 
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @" 
        /// <param name=""request""></param>")}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {(endPoint.IsDeprecated ? "[global::System.Obsolete(\"This method marked as deprecated.\")]" : " ")}
        {(isInterface ? "" : "public async ")}{taskType} {endPoint.MethodName}(
{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: true }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @$" 
            {endPoint.RequestType.CSharpTypeWithoutNullability} request,")}
{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: false }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default){body}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string SerializePropertyAsString(
        MethodParameter property)
    {
        var name = property.Location != null
            ? property.ParameterName
            : "request." + property.Name;
        if (property.Type.IsArray)
        {
            var subType = property.Type.SubTypes.First();
            var additionalConvertSubtype = subType.IsEnum
                ? ".ToValueString()"
                : string.Empty;
            return $"$\"[{{string.Join(\",\", global::System.Linq.Enumerable.Select({name}, x => x{additionalConvertSubtype}))}}]\"";
        }
        
        var additionalConvert = property.Type.IsEnum
            ? $"{(property.IsRequired ? "" : "?")}.ToValueString()"
            : string.Empty;
        
        return property.Type.IsAnyOfLike
            ? string.Join(" ?? ", property.Type.SubTypes.Select((y, i) => y.IsEnum
                ? $"{name}{(property.IsRequired ? "" : "?")}.Value{i + 1}?.ToValueString()"
                : $"{name}{(property.IsRequired ? "" : "?")}.Value{i + 1}?.ToString()").Concat(["string.Empty"]))
            : $"$\"{{{name}{additionalConvert}}}\"";
    }
    
    public static string GeneratePathAndQuery(
        EndPoint endPoint)
    {
        var code = @$" 
            var __pathBuilder = new PathBuilder(
                path: {endPoint.Path},
                baseUri: _httpClient.BaseAddress);";

        var queryParameters = endPoint.QueryParameters
            .Where(x =>
                x.Type.IsEnum ||
                (!x.Type.IsArray || (x.Type.SubTypes[0].Properties.Length == 0 && !x.Type.SubTypes[0].IsArray)))
            .ToArray();

        if (queryParameters.Length > 0 ||
            endPoint.Authorizations.Any(x => x is { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Query }))
        {
            code += @" 
            __pathBuilder";
        }

        if (endPoint.Authorizations.Any(x => x is { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Query }))
        {
            code += @" 
                .AddRequiredParameter(_authorization!.Name, _authorization!.Value)";
        }
        foreach (var parameter in queryParameters)
        {
            var additionalArguments = parameter.Type.IsArray
                ? $", delimiter: \"{parameter.Delimiter}\", explode: {(parameter.Explode ? "true" : "false")}"
                : string.Empty;
            if (parameter.Type.IsArray && parameter.Type.SubTypes[0].CSharpTypeWithoutNullability is not "string")
            {
                additionalArguments = $", selector: static x => {parameter.Selector}" + additionalArguments;
            }
            if (parameter.IsRequired)
            {
                code += $@" 
                .AddRequiredParameter(""{parameter.Id}"", {parameter.Value}{additionalArguments})";
            }
            else
            {
                code += $@" 
                .AddOptionalParameter(""{parameter.Id}"", {parameter.Value}{additionalArguments})";
            }
        }
        
        if (queryParameters.Length > 0 ||
            endPoint.Authorizations.Any(x => x is { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Query }))
        {
            code += @" 
                ;";
        }
        
        code += @" 
            var __path = __pathBuilder.ToString();";
        
        return code.RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateRequestData(
        EndPoint endPoint)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType))
        {
            return " ";
        }
        
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        if (endPoint.IsMultipartFormData)
        {
            return $@" 
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
{endPoint.Parameters.Where(x => !x.IsMultiPartFormDataFilename).Select(x =>
{
    var add = x.Type.IsBinary ? @$" 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.{x.Name} ?? global::System.Array.Empty<byte>())
                {{
                    Headers =
                    {{
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse(""{endPoint.RequestMediaType}""),
                    }},
                }},
                name: ""{x.Id}"",
                fileName: request.{x.Name + "name"} ?? string.Empty);
 " : @$" 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent({SerializePropertyAsString(x)}),
                name: ""{x.Id}"");
 ";
    if (x.IsRequired)
    {
        return add;
    }

    return $@" 
            if ({(x.Location != null ? x.ParameterName : "request." + x.Name)} != {x.ParameterDefaultValue})
            {{
{add.AddIndent(1)}
            }}";
}).Inject()}
            
            httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        var requestContent = endPoint.RequestType.IsBase64
            ? "global::System.Convert.ToBase64String(request)"
            : jsonSerializer.GenerateSerializeCall(endPoint.RequestType, endPoint.Settings.JsonSerializerContext);

        return $@" 
            var __httpRequestContentBody = {requestContent};
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""{endPoint.RequestMediaType}"");
            httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateExtensionMethod(
        EndPoint endPoint, bool isInterface = false)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ||
            endPoint.RequestType.IsArray ||
            endPoint.RequestType.IsEnum ||
            endPoint.RequestType.IsBase64 ||
            endPoint.RequestType.CSharpTypeWithoutNullability is "string")
        {
            return " ";
        }
        
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType.CSharpTypeWithoutNullability}>";
        var cancellationTokenAttribute = endPoint.Stream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var response = endPoint.Stream
            ? "var enumerable = "
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "await "
                : "return await ";
        var configureAwaitResponse = !endPoint.Stream
            ? ".ConfigureAwait(false)"
            : string.Empty;
        var body = isInterface
            ? ";"
            : @$"
        {{
            var request = new {endPoint.RequestType.CSharpTypeWithoutNullability}
            {{
{endPoint.Parameters.Where(x => x.Location == null && (x.IsRequired || !x.IsDeprecated)).Select(x => $@"
                {(x.Name.StartsWith("request", StringComparison.Ordinal) ? x.Name.Replace("request", string.Empty) : x.Name)} = {x.ParameterName},").Inject()}
            }};

            {response}{endPoint.MethodName}(
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                request: request,
                cancellationToken: cancellationToken){configureAwaitResponse};
{(endPoint.Stream ? @"
            
            await foreach (var response in enumerable)
            {
                yield return response;
            }" : " ")}
        }}";
        
        return $@"
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Parameters.Where(static x => x is { IsDeprecated: false } or { IsRequired:true }).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {(endPoint.IsDeprecated ? "[global::System.Obsolete(\"This method marked as deprecated.\")]" : " ")}
        {(isInterface ? "" : "public async ")}{taskType} {endPoint.MethodName}(
{endPoint.Parameters.Where(static x => x.IsRequired).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{endPoint.Parameters.Where(static x => x is { IsRequired: false, IsDeprecated: false }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default){body}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}