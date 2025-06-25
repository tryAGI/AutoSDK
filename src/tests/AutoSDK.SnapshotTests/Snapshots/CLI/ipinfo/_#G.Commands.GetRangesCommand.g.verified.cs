//HintName: G.Commands.GetRangesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetRangesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string domain,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RangesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Domain { get; } = new(
            name: "domain")
        {
            Description = "",
        };

        public GetRangesCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns information about a domain ranges.")
        {
            _client = client;

            Arguments.Add(Domain);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var domain = parseResult.GetRequiredValue(Domain);

            Validate(
                parseResult: parseResult,
                domain: domain,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Ranges.GetRangesAsync(
                domain: domain,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}