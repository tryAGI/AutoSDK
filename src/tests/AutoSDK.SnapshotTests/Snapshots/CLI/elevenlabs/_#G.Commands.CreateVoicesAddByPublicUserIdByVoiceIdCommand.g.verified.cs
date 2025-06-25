//HintName: G.Commands.CreateVoicesAddByPublicUserIdByVoiceIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesAddByPublicUserIdByVoiceIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string publicUserId,
            string voiceId,
            string? xiApiKey,
            string newName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddVoiceResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PublicUserId { get; } = new(
            name: "publicUserId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> NewName { get; } = new(
            name: "newName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateVoicesAddByPublicUserIdByVoiceIdCommand(G.IApi client) : base(
            name: "create",
            description: @"Add a shared voice to your collection of voices.")
        {
            _client = client;

            Arguments.Add(PublicUserId);
            Arguments.Add(VoiceId);
            Arguments.Add(NewName);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var publicUserId = parseResult.GetRequiredValue(PublicUserId);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var newName = parseResult.GetRequiredValue(NewName);

            Validate(
                parseResult: parseResult,
                publicUserId: publicUserId,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                newName: newName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.CreateVoicesAddByPublicUserIdByVoiceIdAsync(
                publicUserId: publicUserId,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                newName: newName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}