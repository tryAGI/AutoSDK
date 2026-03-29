//HintName: G.Commands.SessionsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SessionsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SessionsListStatus? status,
            string? q,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.Session> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.SessionsListStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Q { get; } = new(
            name: "q")
        {
            Description = @"Query sessions by user metadata. See [Querying Sessions by User Metadata](/features/sessions#querying-sessions-by-user-metadata) for the schema of this query.",
        };


        public SessionsListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "sessions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Status);
            Options.Add(Q);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var status = parseResult.GetRequiredValue(Status);
            var q = parseResult.GetRequiredValue(Q);

            Validate(
                parseResult: parseResult,
                status: status,
                q: q,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SessionsListAsync(
                status: status,
                q: q,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}