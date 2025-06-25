//HintName: G.Commands.ActivityListNotificationsForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityListNotificationsForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? all,
            bool? participating,
            global::System.DateTime? since,
            global::System.DateTime? before,
            int? page,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Thread> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> All { get; } = new(
            name: "all")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Participating { get; } = new(
            name: "participating")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };
        public ActivityListNotificationsForAuthenticatedUserCommand(G.IApi client) : base(
            name: "activity",
            description: @"List all notifications for the current user, sorted by most recently updated.")
        {
            _client = client;

            Options.Add(All);
            Options.Add(Participating);
            Options.Add(Since);
            Options.Add(Before);
            Options.Add(Page);
            Options.Add(PerPage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var all = parseResult.GetRequiredValue(All);
            var participating = parseResult.GetRequiredValue(Participating);
            var since = parseResult.GetRequiredValue(Since);
            var before = parseResult.GetRequiredValue(Before);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                all: all,
                participating: participating,
                since: since,
                before: before,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Activity.ActivityListNotificationsForAuthenticatedUserAsync(
                all: all,
                participating: participating,
                since: since,
                before: before,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}