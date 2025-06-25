//HintName: G.Commands.NodesGetClassCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NodesGetClassCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::G.NodesGetClassOutput? output,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.NodesStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.NodesGetClassOutput?> Output { get; } = new(
            name: "output")
        {
            Description = "",
        };
        public NodesGetClassCommand(G.IApi client) : base(
            name: "nodes",
            description: @"Returns node information for the nodes relevant to the collection.")
        {
            _client = client;

            Arguments.Add(ClassName);
            Options.Add(Output);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var output = parseResult.GetRequiredValue(Output);

            Validate(
                parseResult: parseResult,
                className: className,
                output: output,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Nodes.NodesGetClassAsync(
                className: className,
                output: output,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}