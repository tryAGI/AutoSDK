//HintName: G.Commands.AddFundsPaymentFundsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AddFundsPaymentFundsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? session,
            int amount,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> Amount { get; } = new(
            name: "amount")
        {
            Description = @"Amount to add in cents",
        };

        private global::System.CommandLine.Option<string?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };
        public AddFundsPaymentFundsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "add",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Amount);
            Options.Add(Session);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var session = parseResult.GetRequiredValue(Session);
            var amount = parseResult.GetRequiredValue(Amount);

            Validate(
                parseResult: parseResult,
                session: session,
                amount: amount,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AddFundsPaymentFundsPostAsync(
                session: session,
                amount: amount,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}