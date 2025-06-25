//HintName: G.Commands.GetInformationByIpCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetInformationByIpCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string ip,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Ip { get; } = new(
            name: "ip")
        {
            Description = "",
        };

        public GetInformationByIpCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns information about the selected IP.")
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
            var response = await _client.General.GetInformationByIpAsync(
                ip: ip,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}