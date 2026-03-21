//HintName: G.Commands.StartGeneratingCreateTextToSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartGeneratingCreateTextToSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateTextToSpeechResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        };



        public StartGeneratingCreateTextToSpeechCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This endpoint will start a new task to generate speech from text.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(XRunwayVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);

            Validate(
                parseResult: parseResult,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StartGenerating.CreateTextToSpeechAsync(
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}