//HintName: G.Commands.CreateTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"When users trigger a pipeline which uses an API token, the token is
updated with the current time. This field is used to track the last time
the token was used.",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"API token resource ID (used in `name` as the last segment). This conforms
to RFC-1034, which restricts to letters, numbers, and hyphen, with the
first character a letter, the last a letter or a number, and a 63
character maximum.

This field can reflect the client(s) that will use the token.",
        };

        private global::System.CommandLine.Option<int?> Ttl { get; } = new(
            name: "ttl")
        {
            Description = @"The time-to-live in seconds for this resource.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ExpireTime { get; } = new(
            name: "expireTime")
        {
            Description = @"Expiration time.",
        };
        public CreateTokenCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates an API token for the authenticated user.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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