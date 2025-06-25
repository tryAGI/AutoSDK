//HintName: G.Commands.OrgsRemoveMemberCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsRemoveMemberCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public OrgsRemoveMemberCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Removing a user from this list will remove them from all teams and they will no longer have any access to the organization's repositories.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                org: org,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsRemoveMemberAsync(
                org: org,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}