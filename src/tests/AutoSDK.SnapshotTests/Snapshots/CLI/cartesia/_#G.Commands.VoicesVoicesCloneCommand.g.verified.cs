//HintName: G.Commands.VoicesVoicesCloneCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesVoicesCloneCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoicesCloneCartesiaVersion cartesiaVersion,
            byte[]? clip,
            string? clipname,
            string? name,
            string? description,
            global::G.SupportedLanguage? language,
            string? baseVoiceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VoiceMetadata response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoicesCloneCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<byte[]?> Clip { get; } = new(
            name: "clip")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Clipname { get; } = new(
            name: "clipname")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the voice.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A description for the voice.",
        };

        private global::System.CommandLine.Option<global::G.SupportedLanguage?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).",
        };

        private global::System.CommandLine.Option<string?> BaseVoiceId { get; } = new(
            name: "baseVoiceId")
        {
            Description = @"The ID of the voice.",
        };


        public VoicesVoicesCloneCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"Clone a high similarity voice from an audio clip. Clones are more similar to the source clip, but may reproduce background noise. For these, use an audio clip about 5 seconds long.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Clip);
            Options.Add(Clipname);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Language);
            Options.Add(BaseVoiceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var clip = parseResult.GetRequiredValue(Clip);
            var clipname = parseResult.GetRequiredValue(Clipname);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var language = parseResult.GetRequiredValue(Language);
            var baseVoiceId = parseResult.GetRequiredValue(BaseVoiceId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                clip: clip,
                clipname: clipname,
                name: name,
                description: description,
                language: language,
                baseVoiceId: baseVoiceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesCloneAsync(
                cartesiaVersion: cartesiaVersion,
                clip: clip,
                clipname: clipname,
                name: name,
                description: description,
                language: language,
                baseVoiceId: baseVoiceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}