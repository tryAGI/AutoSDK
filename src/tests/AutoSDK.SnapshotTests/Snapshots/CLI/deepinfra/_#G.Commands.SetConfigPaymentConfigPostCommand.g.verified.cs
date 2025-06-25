//HintName: G.Commands.SetConfigPaymentConfigPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SetConfigPaymentConfigPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? session,
            double? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ConfigOut response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"",
        };
        public SetConfigPaymentConfigPostCommand(G.IApi client) : base(
            name: "set",
            description: @"")
        {
            _client = client;

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