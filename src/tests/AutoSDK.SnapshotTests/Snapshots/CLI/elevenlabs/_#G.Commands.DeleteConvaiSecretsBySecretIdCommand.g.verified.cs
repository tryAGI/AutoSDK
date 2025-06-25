//HintName: G.Commands.DeleteConvaiSecretsBySecretIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteConvaiSecretsBySecretIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string secretId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SecretId { get; } = new(
            name: "secretId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public DeleteConvaiSecretsBySecretIdCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete a workspace secret if it's not in use")
        {
            _client = client;

            Arguments.Add(SecretId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var secretId = parseResult.GetRequiredValue(SecretId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                secretId: secretId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ConversationalAI.DeleteConvaiSecretsBySecretIdAsync(
                secretId: secretId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}