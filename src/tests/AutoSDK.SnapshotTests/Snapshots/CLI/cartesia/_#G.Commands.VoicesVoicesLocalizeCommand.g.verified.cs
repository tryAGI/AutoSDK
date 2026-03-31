//HintName: G.Commands.VoicesVoicesLocalizeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesVoicesLocalizeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoicesLocalizeCartesiaVersion cartesiaVersion,
            string voiceId,
            string name,
            string description,
            global::G.LocalizeTargetLanguage language,
            global::G.Gender originalSpeakerGender,
            global::G.LocalizeDialect? dialect,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VoiceMetadata response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoicesLocalizeCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"The ID of the voice to localize.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the new localized voice.",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"The description of the new localized voice.",
        };

        private global::System.CommandLine.Argument<global::G.LocalizeTargetLanguage> Language { get; } = new(
            name: "language")
        {
            Description = @"Target language to localize the voice to.

Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).",
        };

        private global::System.CommandLine.Argument<global::G.Gender> OriginalSpeakerGender { get; } = new(
            name: "originalSpeakerGender")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.LocalizeDialect?> Dialect { get; } = new(
            name: "dialect")
        {
            Description = @"The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).",
        };


        public VoicesVoicesLocalizeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"Create a new voice from an existing voice localized to a new language and dialect.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(VoiceId);
            Arguments.Add(Name);
            Arguments.Add(Description);
            Arguments.Add(Language);
            Arguments.Add(OriginalSpeakerGender);
            Options.Add(Dialect);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var language = parseResult.GetRequiredValue(Language);
            var originalSpeakerGender = parseResult.GetRequiredValue(OriginalSpeakerGender);
            var dialect = parseResult.GetRequiredValue(Dialect);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                voiceId: voiceId,
                name: name,
                description: description,
                language: language,
                originalSpeakerGender: originalSpeakerGender,
                dialect: dialect,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesLocalizeAsync(
                cartesiaVersion: cartesiaVersion,
                voiceId: voiceId,
                name: name,
                description: description,
                language: language,
                originalSpeakerGender: originalSpeakerGender,
                dialect: dialect,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}