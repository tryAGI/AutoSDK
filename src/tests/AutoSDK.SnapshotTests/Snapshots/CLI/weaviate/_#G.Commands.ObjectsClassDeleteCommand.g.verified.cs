//HintName: G.Commands.ObjectsClassDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsClassDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::System.Guid id,
            global::G.ObjectsClassDeleteConsistencyLevel? consistencyLevel,
            string? tenant,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ObjectsClassDeleteConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };
        public ObjectsClassDeleteCommand(G.IApi client) : base(
            name: "objects",
            description: @"Delete an object based on its collection and UUID. <br/><br/>Note: For backward compatibility, beacons also support an older, deprecated format without the collection name. As a result, when deleting a reference, the beacon specified has to match the beacon to be deleted exactly. In other words, if a beacon is present using the old format (without collection name) you also need to specify it the same way. <br/><br/>In the beacon format, you need to always use `localhost` as the host, rather than the actual hostname. `localhost` here refers to the fact that the beacon's target is on the same Weaviate instance, as opposed to a foreign instance.")
        {
            _client = client;

            Arguments.Add(ClassName);
            Arguments.Add(Id);
            Options.Add(ConsistencyLevel);
            Options.Add(Tenant);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var id = parseResult.GetRequiredValue(Id);
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var tenant = parseResult.GetRequiredValue(Tenant);

            Validate(
                parseResult: parseResult,
                className: className,
                id: id,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Objects.ObjectsClassDeleteAsync(
                className: className,
                id: id,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}