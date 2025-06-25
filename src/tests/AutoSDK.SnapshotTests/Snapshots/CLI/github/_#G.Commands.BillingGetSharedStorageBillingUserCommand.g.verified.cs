//HintName: G.Commands.BillingGetSharedStorageBillingUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BillingGetSharedStorageBillingUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CombinedBillingUsage response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public BillingGetSharedStorageBillingUserCommand(G.IApi client) : base(
            name: "billing",
            description: @"Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.

Paid minutes only apply to packages stored for private repositories. For more information, see ""[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).""

OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Billing.BillingGetSharedStorageBillingUserAsync(
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}