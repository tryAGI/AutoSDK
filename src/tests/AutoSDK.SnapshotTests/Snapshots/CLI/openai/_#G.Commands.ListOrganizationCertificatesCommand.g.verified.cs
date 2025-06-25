//HintName: G.Commands.ListOrganizationCertificatesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListOrganizationCertificatesCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? limit,
            string? after,
            global::G.ListOrganizationCertificatesOrder? order,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListCertificatesResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListOrganizationCertificatesOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };
        public ListOrganizationCertificatesCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Order);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var after = parseResult.GetRequiredValue(After);
            var order = parseResult.GetRequiredValue(Order);

            Validate(
                parseResult: parseResult,
                limit: limit,
                after: after,
                order: order,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Certificates.ListOrganizationCertificatesAsync(
                limit: limit,
                after: after,
                order: order,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}