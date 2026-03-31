//HintName: G.Commands.AdminReingestAllStoresCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminReingestAllStoresCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid organizationId,
            string storeIdentifier,
            global::System.Collections.Generic.IList<global::G.VectorStoreFileStatus>? statuses,
            bool? billable,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.VectorStoreFileStatus>?> Statuses { get; } = new(
            name: "statuses")
        {
            Description = @"Statuses of files to reingest",
        };

        private global::System.CommandLine.Option<bool?> Billable { get; } = new(
            name: "billable")
        {
            Description = @"Whether the reingestion is billable to the user",
        };


        public AdminReingestAllStoresCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "reingest",
            description: @"Reingest all stores across all organizations (admin only).

This endpoint creates StoreFileReingestionJob for each store.

Returns:
    dict: Confirmation message with count of jobs created.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(OrganizationId);
            Arguments.Add(StoreIdentifier);
            Options.Add(Statuses);
            Options.Add(Billable);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var statuses = parseResult.GetRequiredValue(Statuses);
            var billable = parseResult.GetRequiredValue(Billable);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                storeIdentifier: storeIdentifier,
                statuses: statuses,
                billable: billable,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Admin.ReingestAllStoresAsync(
                organizationId: organizationId,
                storeIdentifier: storeIdentifier,
                statuses: statuses,
                billable: billable,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}