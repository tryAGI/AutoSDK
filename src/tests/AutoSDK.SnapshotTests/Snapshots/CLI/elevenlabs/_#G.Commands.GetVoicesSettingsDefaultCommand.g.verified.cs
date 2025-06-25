//HintName: G.Commands.GetVoicesSettingsDefaultCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesSettingsDefaultCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceSettingsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        public GetVoicesSettingsDefaultCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the default settings for voices. ""similarity_boost"" corresponds to""Clarity + Similarity Enhancement"" in the web app and ""stability"" corresponds to ""Stability"" slider in the web app.")
        {
            _client = client;


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
            var response = await _client.Voices.GetVoicesSettingsDefaultAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}