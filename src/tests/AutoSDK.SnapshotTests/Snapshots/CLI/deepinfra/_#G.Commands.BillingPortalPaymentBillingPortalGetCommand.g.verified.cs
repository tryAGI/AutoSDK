//HintName: G.Commands.BillingPortalPaymentBillingPortalGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BillingPortalPaymentBillingPortalGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? returnUrl,
            object? session,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BillingPortalOut response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ReturnUrl { get; } = new(
            name: "returnUrl")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };
        public BillingPortalPaymentBillingPortalGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "billing",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ReturnUrl);
            Options.Add(Session);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var returnUrl = parseResult.GetRequiredValue(ReturnUrl);
            var session = parseResult.GetRequiredValue(Session);

            Validate(
                parseResult: parseResult,
                returnUrl: returnUrl,
                session: session,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.BillingPortalPaymentBillingPortalGetAsync(
                returnUrl: returnUrl,
                session: session,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}