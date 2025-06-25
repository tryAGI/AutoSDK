//HintName: G.Commands.GetApiStripeSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetApiStripeSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? isBusiness,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ManageApiStripeSubscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> IsBusiness { get; } = new(
            name: "isBusiness")
        {
            Description = @"Whether the subscription is intended to be used for business or personal use.",
        };
        public GetApiStripeSubscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(IsBusiness);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var isBusiness = parseResult.GetRequiredValue(IsBusiness);

            Validate(
                parseResult: parseResult,
                isBusiness: isBusiness,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Manage.GetApiStripeSubscriptionAsync(
                isBusiness: isBusiness,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}