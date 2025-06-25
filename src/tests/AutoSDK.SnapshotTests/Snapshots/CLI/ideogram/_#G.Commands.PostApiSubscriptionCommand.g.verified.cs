//HintName: G.Commands.PostApiSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PostApiSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RechargeSettings? rechargeSettings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PostApiSubscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.RechargeSettings?> RechargeSettings { get; } = new(
            name: "rechargeSettings")
        {
            Description = @"The current recharge settings for the API subscription.",
        };
        public PostApiSubscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "post",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(RechargeSettings);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var rechargeSettings = parseResult.GetRequiredValue(RechargeSettings);

            Validate(
                parseResult: parseResult,
                rechargeSettings: rechargeSettings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Manage.PostApiSubscriptionAsync(
                rechargeSettings: rechargeSettings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}