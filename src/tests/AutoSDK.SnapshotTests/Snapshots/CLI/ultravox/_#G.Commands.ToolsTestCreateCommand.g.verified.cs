//HintName: G.Commands.ToolsTestCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsTestCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid toolId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ToolId { get; } = new(
            name: "toolId")
        {
            Description = "",
        };

        public ToolsTestCreateCommand(G.IApi client) : base(
            name: "tools",
            description: @"Test a tool by executing it with the provided parameters.")
        {
            _client = client;

            Arguments.Add(ToolId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var toolId = parseResult.GetRequiredValue(ToolId);

            Validate(
                parseResult: parseResult,
                toolId: toolId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tools.ToolsTestCreateAsync(
                toolId: toolId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}