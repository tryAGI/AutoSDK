//HintName: G.Commands.PromptsGetPromptsByCommitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsGetPromptsByCommitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> commits,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Commits { get; } = new(
            name: "commits")
        {
            Description = @"",
        };



        public PromptsGetPromptsByCommitsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get prompts by prompt version commits")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Commits);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commits = parseResult.GetRequiredValue(Commits);

            Validate(
                parseResult: parseResult,
                commits: commits,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.GetPromptsByCommitsAsync(
                commits: commits,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}