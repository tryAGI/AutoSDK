//HintName: G.Commands.GetPrivacyInformationByIpCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPrivacyInformationByIpCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string ip,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PrivacyResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Ip { get; } = new(
            name: "ip")
        {
            Description = "",
        };

        public GetPrivacyInformationByIpCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns privacy information about the selected IP.")
        {
            _client = client;

            Arguments.Add(Ip);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ip = parseResult.GetRequiredValue(Ip);

            Validate(
                parseResult: parseResult,
                ip: ip,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PrivacyDetection.GetPrivacyInformationByIpAsync(
                ip: ip,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}