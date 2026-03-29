//HintName: G.Commands.ExperimentsUpdateExperimentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsUpdateExperimentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? name,
            global::G.JsonNode? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::G.ExperimentUpdateType? type,
            global::G.ExperimentUpdateStatus? status,
            global::System.Collections.Generic.IList<global::G.ExperimentScore>? experimentScores,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonNode?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"Tags",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToAdd { get; } = new(
            name: "tagsToAdd")
        {
            Description = @"Tags to add",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToRemove { get; } = new(
            name: "tagsToRemove")
        {
            Description = @"Tags to remove",
        };

        private global::System.CommandLine.Option<global::G.ExperimentUpdateType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ExperimentUpdateStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"The status of the experiment",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ExperimentScore>?> ExperimentScores { get; } = new(
            name: "experimentScores")
        {
            Description = @"",
        };


        public ExperimentsUpdateExperimentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update experiment by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Name);
            Options.Add(Metadata);
            Options.Add(Tags);
            Options.Add(TagsToAdd);
            Options.Add(TagsToRemove);
            Options.Add(Type);
            Options.Add(Status);
            Options.Add(ExperimentScores);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var tags = parseResult.GetRequiredValue(Tags);
            var tagsToAdd = parseResult.GetRequiredValue(TagsToAdd);
            var tagsToRemove = parseResult.GetRequiredValue(TagsToRemove);
            var type = parseResult.GetRequiredValue(Type);
            var status = parseResult.GetRequiredValue(Status);
            var experimentScores = parseResult.GetRequiredValue(ExperimentScores);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                metadata: metadata,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                type: type,
                status: status,
                experimentScores: experimentScores,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Experiments.UpdateExperimentAsync(
                id: id,
                name: name,
                metadata: metadata,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                type: type,
                status: status,
                experimentScores: experimentScores,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}