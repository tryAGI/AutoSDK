//HintName: G.Commands.OrgsReviewPatGrantRequestCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsReviewPatGrantRequestCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int patRequestId,
            global::G.OrgsReviewPatGrantRequestRequestAction action,
            string? reason,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> PatRequestId { get; } = new(
            name: "patRequestId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OrgsReviewPatGrantRequestRequestAction> Action { get; } = new(
            name: "action")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Reason { get; } = new(
            name: "reason")
        {
            Description = "",
        };
        public OrgsReviewPatGrantRequestCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Approves or denies a pending request to access organization resources via a fine-grained personal access token.

Only GitHub Apps can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(PatRequestId);
            Arguments.Add(Action);
            Options.Add(Reason);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var patRequestId = parseResult.GetRequiredValue(PatRequestId);
            var action = parseResult.GetRequiredValue(Action);
            var reason = parseResult.GetRequiredValue(Reason);

            Validate(
                parseResult: parseResult,
                org: org,
                patRequestId: patRequestId,
                action: action,
                reason: reason,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsReviewPatGrantRequestAsync(
                org: org,
                patRequestId: patRequestId,
                action: action,
                reason: reason,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}