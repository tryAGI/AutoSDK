//HintName: G.Commands.OrgsUpdatePatAccessCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdatePatAccessCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int patId,
            global::G.OrgsUpdatePatAccessRequestAction action,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> PatId { get; } = new(
            name: "patId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdatePatAccessRequestAction> Action { get; } = new(
            name: "action")
        {
            Description = "",
        };
        public OrgsUpdatePatAccessCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Updates the access an organization member has to organization resources via a fine-grained personal access token. Limited to revoking the token's existing access. Limited to revoking a token's existing access.

Only GitHub Apps can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(PatId);
            Options.Add(Action);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var patId = parseResult.GetRequiredValue(PatId);
            var action = parseResult.GetRequiredValue(Action);

            Validate(
                parseResult: parseResult,
                org: org,
                patId: patId,
                action: action,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsUpdatePatAccessAsync(
                org: org,
                patId: patId,
                action: action,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}