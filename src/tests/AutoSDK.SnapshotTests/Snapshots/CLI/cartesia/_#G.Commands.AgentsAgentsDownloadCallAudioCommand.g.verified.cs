//HintName: G.Commands.AgentsAgentsDownloadCallAudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsDownloadCallAudioCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsDownloadCallAudioCartesiaVersion cartesiaVersion,
            string callId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsDownloadCallAudioCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> CallId { get; } = new(
            name: "callId")
        {
            Description = @"The ID of the call.",
        };



        public AgentsAgentsDownloadCallAudioCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"The downloaded audio file is in .wav format. This endpoint streams the audio file content (WAV format) to the client.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(CallId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var callId = parseResult.GetRequiredValue(CallId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                callId: callId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Agents.AgentsDownloadCallAudioAsync(
                cartesiaVersion: cartesiaVersion,
                callId: callId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}