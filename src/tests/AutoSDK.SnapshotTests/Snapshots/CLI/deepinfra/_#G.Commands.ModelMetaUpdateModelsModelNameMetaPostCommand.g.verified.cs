//HintName: G.Commands.ModelMetaUpdateModelsModelNameMetaPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelMetaUpdateModelsModelNameMetaPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelName,
            string? xiApiKey,
            string? description,
            string? githubUrl,
            string? paperUrl,
            string? licenseUrl,
            string? readme,
            string? coverImgUrl,
            global::G.HFTasksE? reportedType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"short model description in plain text",
        };

        private global::System.CommandLine.Option<string?> GithubUrl { get; } = new(
            name: "githubUrl")
        {
            Description = @"source code project link (empty to delete)",
        };

        private global::System.CommandLine.Option<string?> PaperUrl { get; } = new(
            name: "paperUrl")
        {
            Description = @"paper/research link (empty to delete)",
        };

        private global::System.CommandLine.Option<string?> LicenseUrl { get; } = new(
            name: "licenseUrl")
        {
            Description = @"usage license link (empty to delete)",
        };

        private global::System.CommandLine.Option<string?> Readme { get; } = new(
            name: "readme")
        {
            Description = @"markdown flavored model readme",
        };

        private global::System.CommandLine.Option<string?> CoverImgUrl { get; } = new(
            name: "coverImgUrl")
        {
            Description = @"dataurl or regular url to cover image (empty to delete)",
        };

        private global::System.CommandLine.Option<global::G.HFTasksE?> ReportedType { get; } = new(
            name: "reportedType")
        {
            Description = @"",
        };
        public ModelMetaUpdateModelsModelNameMetaPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelName);
            Options.Add(XiApiKey);
            Options.Add(Description);
            Options.Add(GithubUrl);
            Options.Add(PaperUrl);
            Options.Add(LicenseUrl);
            Options.Add(Readme);
            Options.Add(CoverImgUrl);
            Options.Add(ReportedType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelName = parseResult.GetRequiredValue(ModelName);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var description = parseResult.GetRequiredValue(Description);
            var githubUrl = parseResult.GetRequiredValue(GithubUrl);
            var paperUrl = parseResult.GetRequiredValue(PaperUrl);
            var licenseUrl = parseResult.GetRequiredValue(LicenseUrl);
            var readme = parseResult.GetRequiredValue(Readme);
            var coverImgUrl = parseResult.GetRequiredValue(CoverImgUrl);
            var reportedType = parseResult.GetRequiredValue(ReportedType);

            Validate(
                parseResult: parseResult,
                modelName: modelName,
                xiApiKey: xiApiKey,
                description: description,
                githubUrl: githubUrl,
                paperUrl: paperUrl,
                licenseUrl: licenseUrl,
                readme: readme,
                coverImgUrl: coverImgUrl,
                reportedType: reportedType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ModelMetaUpdateModelsModelNameMetaPostAsync(
                modelName: modelName,
                xiApiKey: xiApiKey,
                description: description,
                githubUrl: githubUrl,
                paperUrl: paperUrl,
                licenseUrl: licenseUrl,
                readme: readme,
                coverImgUrl: coverImgUrl,
                reportedType: reportedType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}