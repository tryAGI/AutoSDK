//HintName: G.Commands.AdminApiAdminGetAnalyticsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiAdminGetAnalyticsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::G.AdminGetAnalyticsGroupBy? groupBy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AdminUsageReport response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.DateTime> StartDate { get; } = new(
            name: "startDate")
        {
            Description = @"Start date for the usage report (ISO 8601 date format).",
        };

        private global::System.CommandLine.Argument<global::System.DateTime> EndDate { get; } = new(
            name: "endDate")
        {
            Description = @"End date for the usage report (ISO 8601 date format).",
        };

        private global::System.CommandLine.Option<global::G.AdminGetAnalyticsGroupBy?> GroupBy { get; } = new(
            name: "groupBy")
        {
            Description = @"Optional parameter to group usage statistics. Possible values:
 * `key` - Group by API key
 * `key_and_day` - Group by API key and usage date",
        };


        public AdminApiAdminGetAnalyticsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "admin",
            description: @"Retrieve usage statistics for the organization within a specified date range.
Optionally group the results by API key or by API key and day.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StartDate);
            Arguments.Add(EndDate);
            Options.Add(GroupBy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var startDate = parseResult.GetRequiredValue(StartDate);
            var endDate = parseResult.GetRequiredValue(EndDate);
            var groupBy = parseResult.GetRequiredValue(GroupBy);

            Validate(
                parseResult: parseResult,
                startDate: startDate,
                endDate: endDate,
                groupBy: groupBy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApi.AdminGetAnalyticsAsync(
                startDate: startDate,
                endDate: endDate,
                groupBy: groupBy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}