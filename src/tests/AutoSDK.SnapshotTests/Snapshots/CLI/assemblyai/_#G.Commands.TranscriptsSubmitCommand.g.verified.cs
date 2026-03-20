//HintName: G.Commands.TranscriptsSubmitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranscriptsSubmitCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Transcript response,
            global::System.Threading.CancellationToken cancellationToken);




        public TranscriptsSubmitCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "submit",
            description: @"Create a transcript from a media file that is accessible via a URL.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Transcripts.SubmitAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}