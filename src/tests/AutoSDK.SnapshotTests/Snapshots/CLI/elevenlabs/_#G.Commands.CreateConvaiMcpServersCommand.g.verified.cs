//HintName: G.Commands.CreateConvaiMcpServersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiMcpServersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::G.MCPServerConfigInput config,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MCPServerResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.MCPServerConfigInput> Config { get; } = new(
            name: "config")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateConvaiMcpServersCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a new MCP server configuration in the workspace.")
        {
            _client = client;

            Arguments.Add(Config);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var config = parseResult.GetRequiredValue(Config);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                config: config,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiMcpServersAsync(
                xiApiKey: xiApiKey,
                config: config,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}