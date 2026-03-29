//HintName: G.Commands.AutomationRuleEvaluatorsFindEvaluatorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AutomationRuleEvaluatorsFindEvaluatorsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            string? id,
            string? name,
            string? filters,
            string? sorting,
            int? page,
            int? size,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AutomationRuleEvaluatorPagePublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"Filter automation rules with rule ID containing this value (partial match, like %id%)",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter automation rule evaluators by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };

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


        public AutomationRuleEvaluatorsFindEvaluatorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find project Evaluators")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(Id);
            Options.Add(Name);
            Options.Add(Filters);
            Options.Add(Sorting);
            Options.Add(Page);
            Options.Add(Size);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var filters = parseResult.GetRequiredValue(Filters);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                id: id,
                name: name,
                filters: filters,
                sorting: sorting,
                page: page,
                size: size,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AutomationRuleEvaluators.FindEvaluatorsAsync(
                projectId: projectId,
                id: id,
                name: name,
                filters: filters,
                sorting: sorting,
                page: page,
                size: size,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}