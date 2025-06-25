//HintName: G.Commands.GetOrganizationSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetOrganizationSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetOrganizationSubscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"Oragnization ID",
        };

        public GetOrganizationSubscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns the subscription details of an organization.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(OrganizationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Subscription.GetOrganizationSubscriptionAsync(
                organizationId: organizationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}