//HintName: G.Commands.AppsGetSubscriptionPlanForAccountCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsGetSubscriptionPlanForAccountCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int accountId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MarketplacePurchase response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> AccountId { get; } = new(
            name: "accountId")
        {
            Description = "",
        };

        public AppsGetSubscriptionPlanForAccountCommand(G.IApi client) : base(
            name: "apps",
            description: @"Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.

GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth apps must use [basic authentication](https://docs.github.com/rest/authentication/authenticating-to-the-rest-api#using-basic-authentication) with their client ID and client secret to access this endpoint.")
        {
            _client = client;

            Arguments.Add(AccountId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var accountId = parseResult.GetRequiredValue(AccountId);

            Validate(
                parseResult: parseResult,
                accountId: accountId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsGetSubscriptionPlanForAccountAsync(
                accountId: accountId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}