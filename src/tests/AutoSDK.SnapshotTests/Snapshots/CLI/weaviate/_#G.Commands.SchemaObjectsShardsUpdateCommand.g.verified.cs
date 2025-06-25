//HintName: G.Commands.SchemaObjectsShardsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsShardsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            string shardName,
            string? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ShardStatus response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ShardName { get; } = new(
            name: "shardName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };
        public SchemaObjectsShardsUpdateCommand(G.IApi client) : base(
            name: "schema",
            description: @"Update a shard status for a collection. For example, a shard may have been marked as `READONLY` because its disk was full. After providing more disk space, use this endpoint to set the shard status to `READY` again. There is also a convenience function in each client to set the status of all shards of a collection.")
        {
            _client = client;

            Arguments.Add(ClassName);
            Arguments.Add(ShardName);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var shardName = parseResult.GetRequiredValue(ShardName);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                className: className,
                shardName: shardName,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaObjectsShardsUpdateAsync(
                className: className,
                shardName: shardName,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}