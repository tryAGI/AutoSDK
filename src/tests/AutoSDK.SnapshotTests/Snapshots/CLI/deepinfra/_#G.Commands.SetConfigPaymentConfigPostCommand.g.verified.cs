//HintName: G.Commands.SetConfigPaymentConfigPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SetConfigPaymentConfigPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            object? session,
            double? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ConfigOut response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<object?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Set usage limit (in USD). Negative means no limit.null/not-set means don't change it",
        };
        public SetConfigPaymentConfigPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "set",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Session);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var session = parseResult.GetRequiredValue(Session);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                session: session,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SetConfigPaymentConfigPostAsync(
                session: session,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}