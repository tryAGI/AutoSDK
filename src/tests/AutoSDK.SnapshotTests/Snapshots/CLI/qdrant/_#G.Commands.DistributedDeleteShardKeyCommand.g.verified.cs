//HintName: G.Commands.DistributedDeleteShardKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedDeleteShardKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            int? timeout,
            global::G.ShardKey shardKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteShardKeyResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection to create shards for",
        };

        private global::System.CommandLine.Argument<global::G.ShardKey> ShardKey { get; } = new(
            name: "shardKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };


        public DistributedDeleteShardKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(ShardKey);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var shardKey = parseResult.GetRequiredValue(ShardKey);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                timeout: timeout,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Distributed.DeleteShardKeyAsync(
                collectionName: collectionName,
                timeout: timeout,
                shardKey: shardKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}