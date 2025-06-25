//HintName: G.Commands.CreateProjectsByProjectIdChaptersAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsByProjectIdChaptersAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            string name,
            string? fromUrl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddChapterResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FromUrl { get; } = new(
            name: "fromUrl")
        {
            Description = "",
        };
        public CreateProjectsByProjectIdChaptersAddCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new chapter either as blank or from a URL.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(Name);
            Options.Add(XiApiKey);
            Options.Add(FromUrl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var fromUrl = parseResult.GetRequiredValue(FromUrl);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                name: name,
                fromUrl: fromUrl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.CreateProjectsByProjectIdChaptersAddAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                name: name,
                fromUrl: fromUrl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}