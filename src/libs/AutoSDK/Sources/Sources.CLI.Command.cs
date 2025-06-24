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
        
        return $@"
#nullable enable

namespace {endPoint.Settings.Namespace}
{{
    internal sealed partial class {endPoint.NotAsyncMethodName}Command : global::System.CommandLine.Command
    {{
        private readonly {clientType} _client;

        partial void BeforeRequest(
{endPoint.Parameters.Select((x, i) => @$"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
            CancellationToken cancellationToken);
        partial void AfterRequest(
{(canReturn ? $@" 
            {endPoint.SuccessResponse.Type.CSharpType} response," : " ")}
            CancellationToken cancellationToken);

{endPoint.Parameters.Where(x => x.IsRequired).Select((x, i) => @$"
        private global::System.CommandLine.Argument<{x.Type.CSharpType}> {x.Name.ToPropertyName()} {{ get; }} = new(
            name: ""{x.ParameterName}"")
        {{
            Description = """",
        }};
").Inject()}

{endPoint.Parameters.Where(x => !x.IsRequired).Select((x, i) => @$"
        private global::System.CommandLine.Option<{x.Type.CSharpType}> {x.Name.ToPropertyName()} {{ get; }} = new(
            name: ""{x.ParameterName}"")
        {{
            Description = """",
        }};
").Inject()}
    
        public {endPoint.NotAsyncMethodName}Command({clientType} client) : base(
            name: ""{endPoint.CliAction}"",
            description: ""{endPoint.Description}"")
        {{
            _client = client;

{endPoint.Parameters.Where(x => x.IsRequired).Select((x, i) => @$"
            Arguments.Add({x.Name.ToPropertyName()});").Inject()}
{endPoint.Parameters.Where(x => !x.IsRequired).Select((x, i) => @$"
            Options.Add({x.Name.ToPropertyName()});").Inject()}

            SetAction(HandleAsync);
        }}

        private async Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            CancellationToken cancellationToken = default)
        {{
{endPoint.Parameters.Select((x, i) => @$"
            var {x.ParameterName} = parseResult.GetRequiredValue({x.Name.ToPropertyName()});").Inject()}

            BeforeRequest(
{endPoint.Parameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            {(!canReturn
                ? string.Empty
                : "var response = ")}await _client.{endPoint.Tag.SafeName}.{endPoint.MethodName}(
{endPoint.Parameters.Select((x, i) => @$"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                cancellationToken: cancellationToken);

            AfterRequest(
{(canReturn ? @" 
                response: response," : " ")}
                cancellationToken: cancellationToken);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}