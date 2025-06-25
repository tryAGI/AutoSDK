//HintName: G.Commands.GetAsnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetAsnCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int asn,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AsnResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> Asn { get; } = new(
            name: "asn")
        {
            Description = "",
        };

        public GetAsnCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns information about an AS.")
        {
            _client = client;

            Arguments.Add(Asn);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var asn = parseResult.GetRequiredValue(Asn);

            Validate(
                parseResult: parseResult,
                asn: asn,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Asn.GetAsnAsync(
                asn: asn,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}