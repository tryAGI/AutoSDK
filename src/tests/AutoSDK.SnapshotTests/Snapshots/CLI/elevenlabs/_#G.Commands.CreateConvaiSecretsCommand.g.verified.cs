//HintName: G.Commands.CreateConvaiSecretsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiSecretsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::G.PostWorkspaceSecretRequestType type,
            string name,
            string value,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PostWorkspaceSecretResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Value { get; } = new(
            name: "value")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PostWorkspaceSecretRequestType> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };
        public CreateConvaiSecretsCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a new secret for the workspace")
        {
            _client = client;

            Arguments.Add(Name);
            Arguments.Add(Value);
            Options.Add(XiApiKey);
            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var type = parseResult.GetRequiredValue(Type);
            var name = parseResult.GetRequiredValue(Name);
            var value = parseResult.GetRequiredValue(Value);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                type: type,
                name: name,
                value: value,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiSecretsAsync(
                xiApiKey: xiApiKey,
                type: type,
                name: name,
                value: value,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}