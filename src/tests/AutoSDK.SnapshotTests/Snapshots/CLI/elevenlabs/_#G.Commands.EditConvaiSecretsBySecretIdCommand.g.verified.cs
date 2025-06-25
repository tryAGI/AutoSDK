//HintName: G.Commands.EditConvaiSecretsBySecretIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiSecretsBySecretIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string secretId,
            string? xiApiKey,
            global::G.PatchWorkspaceSecretRequestType type,
            string name,
            string value,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PostWorkspaceSecretResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SecretId { get; } = new(
            name: "secretId")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Option<global::G.PatchWorkspaceSecretRequestType> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };
        public EditConvaiSecretsBySecretIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update an existing secret for the workspace")
        {
            _client = client;

            Arguments.Add(SecretId);
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
            var secretId = parseResult.GetRequiredValue(SecretId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var type = parseResult.GetRequiredValue(Type);
            var name = parseResult.GetRequiredValue(Name);
            var value = parseResult.GetRequiredValue(Value);

            Validate(
                parseResult: parseResult,
                secretId: secretId,
                xiApiKey: xiApiKey,
                type: type,
                name: name,
                value: value,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiSecretsBySecretIdAsync(
                secretId: secretId,
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