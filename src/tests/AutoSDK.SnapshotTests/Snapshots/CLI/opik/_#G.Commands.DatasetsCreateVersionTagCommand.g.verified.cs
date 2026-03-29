//HintName: G.Commands.DatasetsCreateVersionTagCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateVersionTagCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string versionHash,
            global::System.Guid id,
            string tag,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<string> Tag { get; } = new(
            name: "tag")
        {
            Description = @"",
        };



        public DatasetsCreateVersionTagCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Add a tag to a specific dataset version for easy reference (e.g., 'baseline', 'v1.0', 'production')")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VersionHash);
            Arguments.Add(Id);
            Arguments.Add(Tag);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var versionHash = parseResult.GetRequiredValue(VersionHash);
            var id = parseResult.GetRequiredValue(Id);
            var tag = parseResult.GetRequiredValue(Tag);

            Validate(
                parseResult: parseResult,
                versionHash: versionHash,
                id: id,
                tag: tag,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateVersionTagAsync(
                versionHash: versionHash,
                id: id,
                tag: tag,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}