//HintName: G.Commands.CreateOrganizationUsageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateOrganizationUsageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string xRunwayVersion,
            global::System.DateTime? startDate,
            global::System.DateTime? beforeDate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Response24 response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartDate { get; } = new(
            name: "startDate")
        {
            Description = @"The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> BeforeDate { get; } = new(
            name: "beforeDate")
        {
            Description = @"The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.",
        };


        public CreateOrganizationUsageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Fetch credit usage data broken down by model and day for the organization associated with the API key used to make the request. Up to 90 days of data can be queried at a time.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(XRunwayVersion);
            Options.Add(StartDate);
            Options.Add(BeforeDate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
            var startDate = parseResult.GetRequiredValue(StartDate);
            var beforeDate = parseResult.GetRequiredValue(BeforeDate);

            Validate(
                parseResult: parseResult,
                xRunwayVersion: xRunwayVersion,
                startDate: startDate,
                beforeDate: beforeDate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Organization.CreateOrganizationUsageAsync(
                xRunwayVersion: xRunwayVersion,
                startDate: startDate,
                beforeDate: beforeDate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}