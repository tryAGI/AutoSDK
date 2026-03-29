//HintName: G.Commands.TenantGetTenantCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TenantGetTenantCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenantName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetTenantResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TenantName { get; } = new(
            name: "tenantName")
        {
            Description = @"Tenant UUID",
        };



        public TenantGetTenantCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns an existing tenant by name.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TenantName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenantName = parseResult.GetRequiredValue(TenantName);

            Validate(
                parseResult: parseResult,
                tenantName: tenantName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tenant.GetTenantAsync(
                tenantName: tenantName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}