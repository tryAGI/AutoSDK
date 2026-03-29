//HintName: G.Commands.DatasetsDeleteVersionTagCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsDeleteVersionTagCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string versionHash,
            string tag,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VersionHash { get; } = new(
            name: "versionHash")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Tag { get; } = new(
            name: "tag")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };



        public DatasetsDeleteVersionTagCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Remove a tag from a dataset version. The version itself is not deleted, only the tag reference.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VersionHash);
            Arguments.Add(Tag);
            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var versionHash = parseResult.GetRequiredValue(VersionHash);
            var tag = parseResult.GetRequiredValue(Tag);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                versionHash: versionHash,
                tag: tag,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.DeleteVersionTagAsync(
                versionHash: versionHash,
                tag: tag,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}