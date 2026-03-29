//HintName: G.Commands.DatasetsUpdateDatasetVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsUpdateDatasetVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string versionHash,
            global::System.Guid id,
            string? changeDescription,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetVersionPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VersionHash { get; } = new(
            name: "versionHash")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ChangeDescription { get; } = new(
            name: "changeDescription")
        {
            Description = @"Optional description of changes in this version",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToAdd { get; } = new(
            name: "tagsToAdd")
        {
            Description = @"Optional list of tags to add to this version",
        };


        public DatasetsUpdateDatasetVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a dataset version's change_description and/or add new tags")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VersionHash);
            Arguments.Add(Id);
            Options.Add(ChangeDescription);
            Options.Add(TagsToAdd);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var versionHash = parseResult.GetRequiredValue(VersionHash);
            var id = parseResult.GetRequiredValue(Id);
            var changeDescription = parseResult.GetRequiredValue(ChangeDescription);
            var tagsToAdd = parseResult.GetRequiredValue(TagsToAdd);

            Validate(
                parseResult: parseResult,
                versionHash: versionHash,
                id: id,
                changeDescription: changeDescription,
                tagsToAdd: tagsToAdd,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.UpdateDatasetVersionAsync(
                versionHash: versionHash,
                id: id,
                changeDescription: changeDescription,
                tagsToAdd: tagsToAdd,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}