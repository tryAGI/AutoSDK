using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

#pragma warning disable CA1308

public static partial class Sources
{
    public static string GenerateCommand(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return string.Empty;
        }

        var clientType = $"{endPoint.GlobalSettings.Namespace}.I{endPoint.GlobalSettings.ClassName}";
        var canReturn = endPoint.SuccessResponse.Type != TypeData.Default;
        var responseType = !canReturn
            ? null
            : endPoint.RawStream
                ? "global::System.IO.Stream"
                : endPoint.EnumerableStream
                    ? $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>"
                    : endPoint.SuccessResponse.Type.CSharpType;

        var hasDirectRequestBody =
            !string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) &&
            (endPoint.RequestType.IsArray ||
             endPoint.RequestType.IsEnum ||
             endPoint.RequestType.IsBase64 ||
             endPoint.RequestType.IsBinary ||
             endPoint.RequestType.CSharpTypeWithoutNullability is "string");
        var cliParameters = endPoint.Parameters
            .Where(x => !(endPoint.ForcedRequestStreamValue is not null && IsRequestStreamParameter(x)))
            .ToArray();
        var requiredCliParameters = cliParameters
            .Where(x => x.IsRequired)
            .ToArray();
        var optionalCliParameters = cliParameters
            .Where(x => !x.IsRequired)
            .ToArray();

        var newModifierIfRequired = (MethodParameter parameter) =>
            parameter.Name.ToPropertyName() is
                "Name" or
                "Description" or
                "Action" or
                "Children" or
                "Arguments" or
                "Options" or
                "Subcommands" or
                "Validators" or
                "Aliases" or
                "TreatUnmatchedTokensAsErrors" or
                "FirstParent" or
                "Hidden" or
                "Parents"
                ? "new "
                : "";

        return $@"
#nullable enable

namespace {endPoint.Settings.Namespace}
{{
    internal sealed partial class {endPoint.CliCommandClassName} : global::System.CommandLine.Command
    {{
        private readonly {clientType} _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
{cliParameters.Select((x, i) => @$"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? $@"
            {endPoint.RequestType.CSharpType} request," : TrimmedLine)}
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
{(responseType is not null ? $@"
            {responseType} response," : TrimmedLine)}
            global::System.Threading.CancellationToken cancellationToken);

{requiredCliParameters.Select((x, i) => @$"
        private {newModifierIfRequired(x)}global::System.CommandLine.Argument<{x.Type.CSharpType}> {x.Name.ToPropertyName()} {{ get; }} = new(
            name: ""{x.ParameterName}"")
        {{
            Description = @""{x.Description.ClearForCSharp()}"",
        }};
").Inject()}

{optionalCliParameters.Select((x, i) => @$"
        private {newModifierIfRequired(x)}global::System.CommandLine.Option<{x.Type.CSharpType}> {x.Name.ToPropertyName()} {{ get; }} = new(
            name: ""{x.ParameterName}"")
        {{
            Description = @""{x.Description.ClearForCSharp()}"",
        }};
").Inject()}

{(hasDirectRequestBody ? @"
        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: ""request-body"")
        {
            Description = @""The request body as JSON."",
        };
" : TrimmedLine)}

        public {endPoint.CliCommandClassName}(
            {clientType} client,
            global::System.IServiceProvider serviceProvider) : base(
            name: ""{endPoint.CliAction}"",
            description: @""{endPoint.Description.ClearForCSharp()}"")
        {{
            _client = client;
            _serviceProvider = serviceProvider;

{requiredCliParameters.Select((x, i) => @$"
            Arguments.Add({x.Name.ToPropertyName()});").Inject()}
{optionalCliParameters.Select((x, i) => @$"
            Options.Add({x.Name.ToPropertyName()});").Inject()}
{(hasDirectRequestBody ? @"
            Arguments.Add(RequestBody);" : TrimmedLine)}

            Initialize();

            SetAction(HandleAsync);
        }}

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
{cliParameters.Select((x, i) => @$"
            var {x.ParameterName} = parseResult.GetRequiredValue({x.Name.ToPropertyName()});").Inject()}
{(hasDirectRequestBody ? $@"
            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<{endPoint.RequestType.CSharpTypeWithoutNullability}>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException(""Failed to deserialize request body."");" : TrimmedLine)}

            Validate(
                parseResult: parseResult,
{cliParameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? @"
                request: request," : TrimmedLine)}
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            {(!canReturn
                ? "await "
                : endPoint.EnumerableStream
                    ? "var response = "
                    : "var response = await ")}_client.{(!string.IsNullOrWhiteSpace(endPoint.Tag.SafeName)
                    ? $"{endPoint.Tag.SafeName}."
                    : "")}{endPoint.MethodName}(
{cliParameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? @"
                request: request," : TrimmedLine)}
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
{(responseType is not null ? @"
                response: response," : TrimmedLine)}
                cancellationToken: cancellationToken);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
