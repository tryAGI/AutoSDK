//HintName: G.Commands.VoicesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            string name,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Voice response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"An audio file containing a sample of the voice to clone.",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"An audio file containing a sample of the voice to clone.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Name for the cloned voice. Must be unique within your account.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Optional description for the voice. If not provided, a default description will be generated.",
        };
        public VoicesCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"Create a new cloned voice from an audio sample. The created voice will be private to your account.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Name);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesCreateAsync(
                file: file,
                filename: filename,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}