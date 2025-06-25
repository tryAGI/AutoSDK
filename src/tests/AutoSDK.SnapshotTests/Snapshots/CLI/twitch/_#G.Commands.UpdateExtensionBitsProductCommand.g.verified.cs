//HintName: G.Commands.UpdateExtensionBitsProductCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateExtensionBitsProductCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (\_), and periods (.) and is limited to a maximum of 255 characters. No spaces.",
        };

        private global::System.CommandLine.Argument<global::G.UpdateExtensionBitsProductBodyCost> Cost { get; } = new(
            name: "cost")
        {
            Description = @"An object that contains the product's cost information.",
        };

        private global::System.CommandLine.Argument<string> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = @"The product's name as displayed in the extension. The maximum length is 255 characters.",
        };

        private global::System.CommandLine.Option<bool?> InDevelopment { get; } = new(
            name: "inDevelopment")
        {
            Description = @"A Boolean value that indicates whether the product is in development. Set to **true** if the product is in development and not available for public use. The default is **false**.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Expiration { get; } = new(
            name: "expiration")
        {
            Description = @"The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.",
        };

        private global::System.CommandLine.Option<bool?> IsBroadcast { get; } = new(
            name: "isBroadcast")
        {
            Description = @"A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. The default is **false**.",
        };
        public UpdateExtensionBitsProductCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Adds or updates a Bits product that the extension created. If the SKU doesn’t exist, the product is added. You may update all fields except the `sku` field.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must match the extension’s client ID.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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