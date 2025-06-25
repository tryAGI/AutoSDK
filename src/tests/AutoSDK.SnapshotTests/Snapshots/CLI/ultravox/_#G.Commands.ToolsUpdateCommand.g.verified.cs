//HintName: G.Commands.ToolsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid toolId,
            string name,
            global::G.UltravoxV1BaseToolDefinition definition,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ToolDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ToolId { get; } = new(
            name: "toolId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.UltravoxV1BaseToolDefinition> Definition { get; } = new(
            name: "definition")
        {
            Description = @"The base definition of a tool that can be used during a call. Exactly one
 implementation (http or client) should be set.",
        };

        public ToolsUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "tools",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ToolId);
            Arguments.Add(Name);
            Arguments.Add(Definition);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var toolId = parseResult.GetRequiredValue(ToolId);
            var name = parseResult.GetRequiredValue(Name);
            var definition = parseResult.GetRequiredValue(Definition);

            Validate(
                parseResult: parseResult,
                toolId: toolId,
                name: name,
                definition: definition,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tools.ToolsUpdateAsync(
                toolId: toolId,
                name: name,
                definition: definition,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}