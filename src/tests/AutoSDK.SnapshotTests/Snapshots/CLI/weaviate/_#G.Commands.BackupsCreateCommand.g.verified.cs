//HintName: G.Commands.BackupsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string backend,
            string id,
            global::G.BackupConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BackupCreateResponse response,
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

        private global::System.CommandLine.Option<global::G.BackupConfig?> Config { get; } = new(
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
        public BackupsCreateCommand(G.IApi client) : base(
            name: "backups",
            description: @"Start creating a backup for a set of collections. <br/><br/>Notes: <br/>- Weaviate uses gzip compression by default. <br/>- Weaviate stays usable while a backup process is ongoing.")
        {
            _client = client;

            Arguments.Add(Backend);
            Arguments.Add(Id);
            Options.Add(Config);
            Options.Add(Include);
            Options.Add(Exclude);

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

            Validate(
                parseResult: parseResult,
                backend: backend,
                id: id,
                config: config,
                include: include,
                exclude: exclude,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Backups.BackupsCreateAsync(
                backend: backend,
                id: id,
                config: config,
                include: include,
                exclude: exclude,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}