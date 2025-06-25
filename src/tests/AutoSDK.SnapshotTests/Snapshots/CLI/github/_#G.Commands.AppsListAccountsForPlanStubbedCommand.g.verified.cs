//HintName: G.Commands.AppsListAccountsForPlanStubbedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsListAccountsForPlanStubbedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int planId,
            global::G.AppsListAccountsForPlanStubbedSort? sort,
            global::G.AppsListAccountsForPlanStubbedDirection? direction,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.MarketplacePurchase> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> PlanId { get; } = new(
            name: "planId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AppsListAccountsForPlanStubbedSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AppsListAccountsForPlanStubbedDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public AppsListAccountsForPlanStubbedCommand(G.IApi client) : base(
            name: "apps",
            description: @"Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.

GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth apps must use [basic authentication](https://docs.github.com/rest/authentication/authenticating-to-the-rest-api#using-basic-authentication) with their client ID and client secret to access this endpoint.")
        {
            _client = client;

            Arguments.Add(PlanId);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var planId = parseResult.GetRequiredValue(PlanId);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                planId: planId,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsListAccountsForPlanStubbedAsync(
                planId: planId,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}