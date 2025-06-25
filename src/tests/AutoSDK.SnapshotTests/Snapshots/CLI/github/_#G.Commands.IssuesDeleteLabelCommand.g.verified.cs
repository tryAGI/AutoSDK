//HintName: G.Commands.IssuesDeleteLabelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesDeleteLabelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        public IssuesDeleteLabelCommand(G.IApi client) : base(
            name: "issues",
            description: @"Deletes a label using the given label name.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Issues.IssuesDeleteLabelAsync(
                owner: owner,
                repo: repo,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}