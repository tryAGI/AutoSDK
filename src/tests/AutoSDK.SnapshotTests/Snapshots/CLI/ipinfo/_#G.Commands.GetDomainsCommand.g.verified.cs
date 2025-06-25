//HintName: G.Commands.GetDomainsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDomainsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };
        public GetDomainsCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns a list of all of the domains hosted on the provided IP address.")
        {
            _client = client;

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