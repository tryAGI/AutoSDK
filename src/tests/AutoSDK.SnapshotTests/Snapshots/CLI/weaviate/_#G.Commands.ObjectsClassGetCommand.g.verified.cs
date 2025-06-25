//HintName: G.Commands.ObjectsClassGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsClassGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::System.Guid id,
            string? include,
            global::G.ObjectsClassGetConsistencyLevel? consistencyLevel,
            string? nodeName,
            string? tenant,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Object response,
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

        private global::System.CommandLine.Option<string?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ObjectsClassGetConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> NodeName { get; } = new(
            name: "nodeName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };
        public ObjectsClassGetCommand(G.IApi client) : base(
            name: "objects",
            description: @"Get a data object based on its collection and UUID. Also available as Websocket bus.")
        {
            _client = client;

            Arguments.Add(ClassName);
            Arguments.Add(Id);
            Options.Add(Include);
            Options.Add(ConsistencyLevel);
            Options.Add(NodeName);
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
            var include = parseResult.GetRequiredValue(Include);
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var nodeName = parseResult.GetRequiredValue(NodeName);
            var tenant = parseResult.GetRequiredValue(Tenant);

            Validate(
                parseResult: parseResult,
                className: className,
                id: id,
                include: include,
                consistencyLevel: consistencyLevel,
                nodeName: nodeName,
                tenant: tenant,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Objects.ObjectsClassGetAsync(
                className: className,
                id: id,
                include: include,
                consistencyLevel: consistencyLevel,
                nodeName: nodeName,
                tenant: tenant,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}