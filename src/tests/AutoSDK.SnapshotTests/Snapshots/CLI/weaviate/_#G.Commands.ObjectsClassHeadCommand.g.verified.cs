//HintName: G.Commands.ObjectsClassHeadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsClassHeadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::System.Guid id,
            global::G.ObjectsClassHeadConsistencyLevel? consistencyLevel,
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

        private global::System.CommandLine.Option<global::G.ObjectsClassHeadConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };
        public ObjectsClassHeadCommand(G.IApi client) : base(
            name: "objects",
            description: @"Checks if a data object exists based on its collection and uuid without retrieving it. <br/><br/>Internally it skips reading the object from disk other than checking if it is present. Thus it does not use resources on marshalling, parsing, etc., and is faster. Note the resulting HTTP request has no body; the existence of an object is indicated solely by the status code.")
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
            await _client.Objects.ObjectsClassHeadAsync(
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