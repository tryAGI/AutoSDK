//HintName: G.Commands.BackupsRestoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupsRestoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string backend,
            string id,
            global::G.RestoreConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BackupRestoreResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Backend { get; } = new(
            name: "backend")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RestoreConfig?> Config { get; } = new(
            name: "config")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> NodeMapping { get; } = new(
            name: "nodeMapping")
        {
            Description = "",
        };
        public BackupsRestoreCommand(G.IApi client) : base(
            name: "backups",
            description: @"Starts a process of restoring a backup for a set of collections. <br/><br/>Any backup can be restored to any machine, as long as the number of nodes between source and target are identical.<br/><br/>Requrements:<br/><br/>- None of the collections to be restored already exist on the target restoration node(s).<br/>- The node names of the backed-up collections' must match those of the target restoration node(s).")
        {
            _client = client;

            Arguments.Add(Backend);
            Arguments.Add(Id);
            Options.Add(Config);
            Options.Add(Include);
            Options.Add(Exclude);
            Options.Add(NodeMapping);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var backend = parseResult.GetRequiredValue(Backend);
            var id = parseResult.GetRequiredValue(Id);
            var config = parseResult.GetRequiredValue(Config);
            var include = parseResult.GetRequiredValue(Include);
            var exclude = parseResult.GetRequiredValue(Exclude);
            var nodeMapping = parseResult.GetRequiredValue(NodeMapping);

            Validate(
                parseResult: parseResult,
                backend: backend,
                id: id,
                config: config,
                include: include,
                exclude: exclude,
                nodeMapping: nodeMapping,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Backups.BackupsRestoreAsync(
                backend: backend,
                id: id,
                config: config,
                include: include,
                exclude: exclude,
                nodeMapping: nodeMapping,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}