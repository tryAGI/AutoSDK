//HintName: G.Commands.ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string apiToken,
            string? xiApiKey,
            string projectIdOrName,
            bool isSensitive,
            bool envDevelopment,
            bool envPreview,
            bool envProduction,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiToken { get; } = new(
            name: "apiToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ProjectIdOrName { get; } = new(
            name: "projectIdOrName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> IsSensitive { get; } = new(
            name: "isSensitive")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> EnvDevelopment { get; } = new(
            name: "envDevelopment")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> EnvPreview { get; } = new(
            name: "envPreview")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> EnvProduction { get; } = new(
            name: "envProduction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostCommand(G.IApi client) : base(
            name: "export",
            description: @"")
        {
            _client = client;

            Arguments.Add(ApiToken);
            Arguments.Add(ProjectIdOrName);
            Arguments.Add(IsSensitive);
            Arguments.Add(EnvDevelopment);
            Arguments.Add(EnvPreview);
            Arguments.Add(EnvProduction);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var apiToken = parseResult.GetRequiredValue(ApiToken);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var projectIdOrName = parseResult.GetRequiredValue(ProjectIdOrName);
            var isSensitive = parseResult.GetRequiredValue(IsSensitive);
            var envDevelopment = parseResult.GetRequiredValue(EnvDevelopment);
            var envPreview = parseResult.GetRequiredValue(EnvPreview);
            var envProduction = parseResult.GetRequiredValue(EnvProduction);

            Validate(
                parseResult: parseResult,
                apiToken: apiToken,
                xiApiKey: xiApiKey,
                projectIdOrName: projectIdOrName,
                isSensitive: isSensitive,
                envDevelopment: envDevelopment,
                envPreview: envPreview,
                envProduction: envProduction,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostAsync(
                apiToken: apiToken,
                xiApiKey: xiApiKey,
                projectIdOrName: projectIdOrName,
                isSensitive: isSensitive,
                envDevelopment: envDevelopment,
                envPreview: envPreview,
                envProduction: envProduction,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}