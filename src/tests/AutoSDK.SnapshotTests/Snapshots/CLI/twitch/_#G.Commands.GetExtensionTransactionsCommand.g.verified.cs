//HintName: G.Commands.GetExtensionTransactionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetExtensionTransactionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string extensionId,
            global::System.Collections.Generic.IList<string>? id,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetExtensionTransactionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The ID of the extension whose list of transactions you want to get.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"A transaction ID used to filter the list of transactions. Specify this parameter for each transaction you want to get. For example, `id=1234&id=5678`. You may specify a maximum of 100 IDs.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetExtensionTransactionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets an extension’s list of transactions. A transaction records the exchange of a currency (for example, Bits) for a digital product.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExtensionId);
            Options.Add(Id);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var id = parseResult.GetRequiredValue(Id);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                extensionId: extensionId,
                id: id,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Bits.GetExtensionTransactionsAsync(
                extensionId: extensionId,
                id: id,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}