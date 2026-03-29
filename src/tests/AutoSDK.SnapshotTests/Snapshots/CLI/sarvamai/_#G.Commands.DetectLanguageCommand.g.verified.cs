//HintName: G.Commands.DetectLanguageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DetectLanguageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string input,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DetectLanguageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"Text for language and script identification (max 1000 characters)",
        };



        public DetectLanguageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "detect",
            description: @"Identifies the language and script of input text.
Max 1000 characters per request.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);

            Validate(
                parseResult: parseResult,
                input: input,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DetectLanguageAsync(
                input: input,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}