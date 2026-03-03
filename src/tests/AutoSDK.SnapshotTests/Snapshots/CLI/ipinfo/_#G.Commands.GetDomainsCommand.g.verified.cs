//HintName: G.Commands.GetDomainsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDomainsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string ip,
            int? page,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DomainsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Ip { get; } = new(
            name: "ip")
        {
            Description = @"A single IPv4 or IPv6 IP address.",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"The page query parameter can be used to go through paginated records. page starts at 0 and the parameter is part of the response when included in request.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The API returns 100 domains per page and has a limit of 1000 domains per page. We return up to 10 million results. The limit parameter can be used to control the number of domains per page.",
        };


        public GetDomainsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns a list of all of the domains hosted on the provided IP address.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Ip);
            Options.Add(Page);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ip = parseResult.GetRequiredValue(Ip);
            var page = parseResult.GetRequiredValue(Page);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                ip: ip,
                page: page,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Domains.GetDomainsAsync(
                ip: ip,
                page: page,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}