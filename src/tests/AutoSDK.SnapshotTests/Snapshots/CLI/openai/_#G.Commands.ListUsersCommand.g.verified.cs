//HintName: G.Commands.ListUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? limit,
            string? after,
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UserListResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Emails { get; } = new(
            name: "emails")
        {
            Description = "",
        };
        public ListUsersCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Emails);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var after = parseResult.GetRequiredValue(After);
            var emails = parseResult.GetRequiredValue(Emails);

            Validate(
                parseResult: parseResult,
                limit: limit,
                after: after,
                emails: emails,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.ListUsersAsync(
                limit: limit,
                after: after,
                emails: emails,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}