//HintName: G.Commands.NodesGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NodesGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.NodesGetOutput? output,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.NodesStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.NodesGetOutput?> Output { get; } = new(
            name: "output")
        {
            Description = "",
        };
        public NodesGetCommand(G.IApi client) : base(
            name: "nodes",
            description: @"Returns node information for the entire database.")
        {
            _client = client;

            Options.Add(Output);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var output = parseResult.GetRequiredValue(Output);

            Validate(
                parseResult: parseResult,
                output: output,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Nodes.NodesGetAsync(
                output: output,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}