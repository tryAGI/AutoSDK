//HintName: G.Commands.ReposTransferCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposTransferCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string newOwner,
            string? newName,
            global::System.Collections.Generic.IList<int>? teamIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MinimalRepository response,
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

        private global::System.CommandLine.Argument<string> NewOwner { get; } = new(
            name: "newOwner")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> NewName { get; } = new(
            name: "newName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> TeamIds { get; } = new(
            name: "teamIds")
        {
            Description = "",
        };
        public ReposTransferCommand(G.IApi client) : base(
            name: "repos",
            description: @"A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original `owner`, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(NewOwner);
            Options.Add(NewName);
            Options.Add(TeamIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var newOwner = parseResult.GetRequiredValue(NewOwner);
            var newName = parseResult.GetRequiredValue(NewName);
            var teamIds = parseResult.GetRequiredValue(TeamIds);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                newOwner: newOwner,
                newName: newName,
                teamIds: teamIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposTransferAsync(
                owner: owner,
                repo: repo,
                newOwner: newOwner,
                newName: newName,
                teamIds: teamIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}