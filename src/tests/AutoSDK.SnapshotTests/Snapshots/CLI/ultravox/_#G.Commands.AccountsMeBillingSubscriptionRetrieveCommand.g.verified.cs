//HintName: G.Commands.AccountsMeBillingSubscriptionRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AccountsMeBillingSubscriptionRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public AccountsMeBillingSubscriptionRetrieveCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "accounts",
            description: @"Redirects to the billing portal for the current account.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Accounts.AccountsMeBillingSubscriptionRetrieveAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}