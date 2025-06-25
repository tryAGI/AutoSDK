//HintName: G.Commands.OrgsReviewPatGrantRequestsInBulkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsReviewPatGrantRequestsInBulkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<int>? patRequestIds,
            global::G.OrgsReviewPatGrantRequestsInBulkRequestAction action,
            string? reason,
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

        private global::System.CommandLine.Argument<global::G.OrgsReviewPatGrantRequestsInBulkRequestAction> Action { get; } = new(
            name: "action")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> PatRequestIds { get; } = new(
            name: "patRequestIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Reason { get; } = new(
            name: "reason")
        {
            Description = "",
        };
        public OrgsReviewPatGrantRequestsInBulkCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.

Only GitHub Apps can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Action);
            Options.Add(PatRequestIds);
            Options.Add(Reason);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var patRequestIds = parseResult.GetRequiredValue(PatRequestIds);
            var action = parseResult.GetRequiredValue(Action);
            var reason = parseResult.GetRequiredValue(Reason);

            Validate(
                parseResult: parseResult,
                org: org,
                patRequestIds: patRequestIds,
                action: action,
                reason: reason,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsReviewPatGrantRequestsInBulkAsync(
                org: org,
                patRequestIds: patRequestIds,
                action: action,
                reason: reason,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}