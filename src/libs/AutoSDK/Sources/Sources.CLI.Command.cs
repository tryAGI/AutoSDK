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

        var hasDirectRequestBody =
            !string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) &&
            (endPoint.RequestType.IsArray ||
             endPoint.RequestType.IsEnum ||
             endPoint.RequestType.IsBase64 ||
             endPoint.RequestType.IsBinary ||
             endPoint.RequestType.CSharpTypeWithoutNullability is "string");

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
{endPoint.Parameters.Select((x, i) => @$"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? $@"
            {endPoint.RequestType.CSharpType} request," : TrimmedLine)}
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
{(canReturn ? $@"
            {endPoint.SuccessResponse.Type.CSharpType} response," : TrimmedLine)}
            global::System.Threading.CancellationToken cancellationToken);

{endPoint.Parameters.Where(x => x.IsRequired).Select((x, i) => @$"
        private {newModifierIfRequired(x)}global::System.CommandLine.Argument<{x.Type.CSharpType}> {x.Name.ToPropertyName()} {{ get; }} = new(
            name: ""{x.ParameterName}"")
        {{
            Description = @""{x.Description.ClearForCSharp()}"",
        }};
").Inject()}

{endPoint.Parameters.Where(x => !x.IsRequired).Select((x, i) => @$"
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

{endPoint.Parameters.Where(x => x.IsRequired).Select((x, i) => @$"
            Arguments.Add({x.Name.ToPropertyName()});").Inject()}
{endPoint.Parameters.Where(x => !x.IsRequired).Select((x, i) => @$"
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
{endPoint.Parameters.Select((x, i) => @$"
            var {x.ParameterName} = parseResult.GetRequiredValue({x.Name.ToPropertyName()});").Inject()}
{(hasDirectRequestBody ? $@"
            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<{endPoint.RequestType.CSharpTypeWithoutNullability}>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException(""Failed to deserialize request body."");" : TrimmedLine)}

            Validate(
                parseResult: parseResult,
{endPoint.Parameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? @"
                request: request," : TrimmedLine)}
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            {(!canReturn
                ? string.Empty
                : "var response = ")}await _client.{(!string.IsNullOrWhiteSpace(endPoint.Tag.SafeName)
                    ? $"{endPoint.Tag.SafeName}."
                    : "")}{endPoint.MethodName}(
{endPoint.Parameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
{(hasDirectRequestBody ? @"
                request: request," : TrimmedLine)}
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
{(canReturn ? @"
                response: response," : TrimmedLine)}
                cancellationToken: cancellationToken);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
