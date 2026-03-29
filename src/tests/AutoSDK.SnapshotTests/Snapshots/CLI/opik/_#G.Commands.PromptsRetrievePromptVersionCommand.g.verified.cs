//HintName: G.Commands.PromptsRetrievePromptVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsRetrievePromptVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            string? commit,
            string? projectName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptVersionDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Commit { get; } = new(
            name: "commit")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If provided, scopes the search to the specified project",
        };


        public PromptsRetrievePromptVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"Retrieve prompt version")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(Commit);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var commit = parseResult.GetRequiredValue(Commit);
            var projectName = parseResult.GetRequiredValue(ProjectName);

            Validate(
                parseResult: parseResult,
                name: name,
                commit: commit,
                projectName: projectName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.RetrievePromptVersionAsync(
                name: name,
                commit: commit,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}