//HintName: G.Commands.ProjectsGetProjectStatsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetProjectStatsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            string? name,
            string? sorting,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ProjectStatsSummary response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter projects by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };


        public ProjectsGetProjectStatsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get Project Stats")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Name);
            Options.Add(Sorting);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var name = parseResult.GetRequiredValue(Name);
            var sorting = parseResult.GetRequiredValue(Sorting);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                name: name,
                sorting: sorting,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.GetProjectStatsAsync(
                page: page,
                size: size,
                name: name,
                sorting: sorting,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}