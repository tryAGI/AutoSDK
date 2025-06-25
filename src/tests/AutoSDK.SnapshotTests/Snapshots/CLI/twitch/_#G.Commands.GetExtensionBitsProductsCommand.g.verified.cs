//HintName: G.Commands.GetExtensionBitsProductsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetExtensionBitsProductsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? shouldIncludeAll,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetExtensionBitsProductsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> ShouldIncludeAll { get; } = new(
            name: "shouldIncludeAll")
        {
            Description = @"",
        };
        public GetExtensionBitsProductsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the list of Bits products that belongs to the extension. The client ID in the app access token identifies the extension.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must be the extension’s client ID.")
        {
            _client = client;

            Options.Add(ShouldIncludeAll);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var shouldIncludeAll = parseResult.GetRequiredValue(ShouldIncludeAll);

            Validate(
                parseResult: parseResult,
                shouldIncludeAll: shouldIncludeAll,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extensions.GetExtensionBitsProductsAsync(
                shouldIncludeAll: shouldIncludeAll,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}