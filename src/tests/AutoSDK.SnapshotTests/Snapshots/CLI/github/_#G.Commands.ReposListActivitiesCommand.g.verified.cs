//HintName: G.Commands.ReposListActivitiesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposListActivitiesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.ReposListActivitiesDirection? direction,
            int? perPage,
            string? before,
            string? after,
            string? @ref,
            string? actor,
            global::G.ReposListActivitiesTimePeriod? timePeriod,
            global::G.ReposListActivitiesActivityType? activityType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Activity> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListActivitiesDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Actor { get; } = new(
            name: "actor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListActivitiesTimePeriod?> TimePeriod { get; } = new(
            name: "timePeriod")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListActivitiesActivityType?> ActivityType { get; } = new(
            name: "activityType")
        {
            Description = "",
        };
        public ReposListActivitiesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Lists a detailed history of changes to a repository, such as pushes, merges, force pushes, and branch changes, and associates these changes with commits and users.

For more information about viewing repository activity,
see ""[Viewing activity and data for your repository](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Ref);
            Options.Add(Actor);
            Options.Add(TimePeriod);
            Options.Add(ActivityType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var @ref = parseResult.GetRequiredValue(Ref);
            var actor = parseResult.GetRequiredValue(Actor);
            var timePeriod = parseResult.GetRequiredValue(TimePeriod);
            var activityType = parseResult.GetRequiredValue(ActivityType);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                @ref: @ref,
                actor: actor,
                timePeriod: timePeriod,
                activityType: activityType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposListActivitiesAsync(
                owner: owner,
                repo: repo,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                @ref: @ref,
                actor: actor,
                timePeriod: timePeriod,
                activityType: activityType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}