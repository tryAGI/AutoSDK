//HintName: G.Commands.OrgsUpdatePatAccessesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdatePatAccessesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.OrgsUpdatePatAccessesRequestAction action,
            global::System.Collections.Generic.IList<int> patIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<int>> PatIds { get; } = new(
            name: "patIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdatePatAccessesRequestAction> Action { get; } = new(
            name: "action")
        {
            Description = "",
        };
        public OrgsUpdatePatAccessesCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token's existing access.

Only GitHub Apps can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(PatIds);
            Options.Add(Action);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var action = parseResult.GetRequiredValue(Action);
            var patIds = parseResult.GetRequiredValue(PatIds);

            Validate(
                parseResult: parseResult,
                org: org,
                action: action,
                patIds: patIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsUpdatePatAccessesAsync(
                org: org,
                action: action,
                patIds: patIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}