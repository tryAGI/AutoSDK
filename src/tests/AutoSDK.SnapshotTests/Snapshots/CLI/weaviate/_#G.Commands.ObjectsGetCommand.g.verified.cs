//HintName: G.Commands.ObjectsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? include,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Object response,
            global::System.Threading.CancellationToken cancellationToken);

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
        public ObjectsGetCommand(G.IApi client) : base(
            name: "objects",
            description: @"Get a specific object based on its UUID. Also available as Websocket bus.")
        {
            _client = client;

            Arguments.Add(Id);
            Options.Add(Include);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var include = parseResult.GetRequiredValue(Include);

            Validate(
                parseResult: parseResult,
                id: id,
                include: include,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Objects.ObjectsGetAsync(
                id: id,
                include: include,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}