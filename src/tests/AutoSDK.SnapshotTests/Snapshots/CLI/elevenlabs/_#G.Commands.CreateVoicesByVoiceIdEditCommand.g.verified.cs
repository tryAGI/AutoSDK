//HintName: G.Commands.CreateVoicesByVoiceIdEditCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesByVoiceIdEditCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            string name,
            global::System.Collections.Generic.IList<byte[]>? files,
            bool? removeBackgroundNoise,
            string? description,
            string? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EditVoiceResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<byte[]>?> Files { get; } = new(
            name: "files")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RemoveBackgroundNoise { get; } = new(
            name: "removeBackgroundNoise")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };
        public CreateVoicesByVoiceIdEditCommand(G.IApi client) : base(
            name: "create",
            description: @"Edit a voice created by you.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Name);
            Options.Add(XiApiKey);
            Options.Add(Files);
            Options.Add(RemoveBackgroundNoise);
            Options.Add(Description);
            Options.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var files = parseResult.GetRequiredValue(Files);
            var removeBackgroundNoise = parseResult.GetRequiredValue(RemoveBackgroundNoise);
            var description = parseResult.GetRequiredValue(Description);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.CreateVoicesByVoiceIdEditAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}