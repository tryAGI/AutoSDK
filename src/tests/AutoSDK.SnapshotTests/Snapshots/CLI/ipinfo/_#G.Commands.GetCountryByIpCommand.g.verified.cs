//HintName: G.Commands.GetCountryByIpCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCountryByIpCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string ip,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Ip { get; } = new(
            name: "ip")
        {
            Description = @"A single IPv4 or IPv6 IP address.",
        };



        public GetCountryByIpCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns a country for the selected IP.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.Single.GetCountryByIpAsync(
                ip: ip,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}