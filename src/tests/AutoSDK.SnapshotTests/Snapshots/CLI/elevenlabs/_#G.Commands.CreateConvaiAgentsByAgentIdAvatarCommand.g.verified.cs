//HintName: G.Commands.CreateConvaiAgentsByAgentIdAvatarCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiAgentsByAgentIdAvatarCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentId,
            string? xiApiKey,
            byte[] avatarFile,
            string avatarFilename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PostAgentAvatarResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<byte[]> AvatarFile { get; } = new(
            name: "avatarFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AvatarFilename { get; } = new(
            name: "avatarFilename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateConvaiAgentsByAgentIdAvatarCommand(G.IApi client) : base(
            name: "create",
            description: @"Sets the avatar for an agent displayed in the widget")
        {
            _client = client;

            Arguments.Add(AgentId);
            Arguments.Add(AvatarFile);
            Arguments.Add(AvatarFilename);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var avatarFile = parseResult.GetRequiredValue(AvatarFile);
            var avatarFilename = parseResult.GetRequiredValue(AvatarFilename);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                xiApiKey: xiApiKey,
                avatarFile: avatarFile,
                avatarFilename: avatarFilename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiAgentsByAgentIdAvatarAsync(
                agentId: agentId,
                xiApiKey: xiApiKey,
                avatarFile: avatarFile,
                avatarFilename: avatarFilename,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}