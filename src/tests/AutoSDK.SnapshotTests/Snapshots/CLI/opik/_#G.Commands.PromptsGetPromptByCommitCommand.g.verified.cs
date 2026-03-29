//HintName: G.Commands.PromptsGetPromptByCommitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsGetPromptByCommitCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string commit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Commit { get; } = new(
            name: "commit")
        {
            Description = @"",
        };



        public PromptsGetPromptByCommitCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get prompt by commit")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Commit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commit = parseResult.GetRequiredValue(Commit);

            Validate(
                parseResult: parseResult,
                commit: commit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.GetPromptByCommitAsync(
                commit: commit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}