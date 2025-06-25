//HintName: G.Commands.CreateTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.DateTime? lastUseTime,
            string? id,
            int? ttl,
            global::System.DateTime? expireTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateTokenResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.DateTime?> LastUseTime { get; } = new(
            name: "lastUseTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Ttl { get; } = new(
            name: "ttl")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ExpireTime { get; } = new(
            name: "expireTime")
        {
            Description = @"",
        };
        public CreateTokenCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates an API token for the authenticated user.")
        {
            _client = client;

            Options.Add(LastUseTime);
            Options.Add(Id);
            Options.Add(Ttl);
            Options.Add(ExpireTime);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var lastUseTime = parseResult.GetRequiredValue(LastUseTime);
            var id = parseResult.GetRequiredValue(Id);
            var ttl = parseResult.GetRequiredValue(Ttl);
            var expireTime = parseResult.GetRequiredValue(ExpireTime);

            Validate(
                parseResult: parseResult,
                lastUseTime: lastUseTime,
                id: id,
                ttl: ttl,
                expireTime: expireTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.CreateTokenAsync(
                lastUseTime: lastUseTime,
                id: id,
                ttl: ttl,
                expireTime: expireTime,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}