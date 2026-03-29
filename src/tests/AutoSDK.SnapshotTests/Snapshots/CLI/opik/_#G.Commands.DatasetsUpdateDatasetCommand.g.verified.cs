//HintName: G.Commands.DatasetsUpdateDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsUpdateDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string name,
            string? description,
            global::G.DatasetUpdateVisibility? visibility,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.DatasetUpdateVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };


        public DatasetsUpdateDatasetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update dataset by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Name);
            Options.Add(Description);
            Options.Add(Visibility);
            Options.Add(Tags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var tags = parseResult.GetRequiredValue(Tags);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                description: description,
                visibility: visibility,
                tags: tags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.UpdateDatasetAsync(
                id: id,
                name: name,
                description: description,
                visibility: visibility,
                tags: tags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}