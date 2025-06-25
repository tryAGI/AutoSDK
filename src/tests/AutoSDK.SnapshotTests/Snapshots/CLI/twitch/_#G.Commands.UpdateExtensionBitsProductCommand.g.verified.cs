//HintName: G.Commands.UpdateExtensionBitsProductCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateExtensionBitsProductCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string sku,
            global::G.UpdateExtensionBitsProductBodyCost cost,
            string displayName,
            bool? inDevelopment,
            global::System.DateTime? expiration,
            bool? isBroadcast,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateExtensionBitsProductResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Sku { get; } = new(
            name: "sku")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.UpdateExtensionBitsProductBodyCost> Cost { get; } = new(
            name: "cost")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> InDevelopment { get; } = new(
            name: "inDevelopment")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Expiration { get; } = new(
            name: "expiration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsBroadcast { get; } = new(
            name: "isBroadcast")
        {
            Description = @"",
        };
        public UpdateExtensionBitsProductCommand(G.IApi client) : base(
            name: "update",
            description: @"Adds or updates a Bits product that the extension created. If the SKU doesn’t exist, the product is added. You may update all fields except the `sku` field.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must match the extension’s client ID.")
        {
            _client = client;

            Arguments.Add(Sku);
            Arguments.Add(Cost);
            Arguments.Add(DisplayName);
            Options.Add(InDevelopment);
            Options.Add(Expiration);
            Options.Add(IsBroadcast);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sku = parseResult.GetRequiredValue(Sku);
            var cost = parseResult.GetRequiredValue(Cost);
            var displayName = parseResult.GetRequiredValue(DisplayName);
            var inDevelopment = parseResult.GetRequiredValue(InDevelopment);
            var expiration = parseResult.GetRequiredValue(Expiration);
            var isBroadcast = parseResult.GetRequiredValue(IsBroadcast);

            Validate(
                parseResult: parseResult,
                sku: sku,
                cost: cost,
                displayName: displayName,
                inDevelopment: inDevelopment,
                expiration: expiration,
                isBroadcast: isBroadcast,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extensions.UpdateExtensionBitsProductAsync(
                sku: sku,
                cost: cost,
                displayName: displayName,
                inDevelopment: inDevelopment,
                expiration: expiration,
                isBroadcast: isBroadcast,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}