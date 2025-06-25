//HintName: G.Commands.AdminApiKeysListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiKeysListCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? after,
            global::G.AdminApiKeysListOrder? order,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ApiKeyList response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AdminApiKeysListOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };
        public AdminApiKeysListCommand(G.IOpenAiClient client) : base(
            name: "admin",
            description: @"Retrieve a paginated list of organization admin API keys.")
        {
            _client = client;

            Options.Add(After);
            Options.Add(Order);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var after = parseResult.GetRequiredValue(After);
            var order = parseResult.GetRequiredValue(Order);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                after: after,
                order: order,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApiKeysListAsync(
                after: after,
                order: order,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}