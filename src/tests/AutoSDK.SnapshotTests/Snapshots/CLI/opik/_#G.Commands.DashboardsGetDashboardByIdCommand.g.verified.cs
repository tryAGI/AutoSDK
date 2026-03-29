//HintName: G.Commands.DashboardsGetDashboardByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DashboardsGetDashboardByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid dashboardId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DashboardPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DashboardId { get; } = new(
            name: "dashboardId")
        {
            Description = @"",
        };



        public DashboardsGetDashboardByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get dashboard by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DashboardId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dashboardId = parseResult.GetRequiredValue(DashboardId);

            Validate(
                parseResult: parseResult,
                dashboardId: dashboardId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dashboards.GetDashboardByIdAsync(
                dashboardId: dashboardId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}