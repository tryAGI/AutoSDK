//HintName: G.Commands.GetOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            global::G.GetOrganizationView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetOrganizationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetOrganizationView?> View { get; } = new(
            name: "view")
        {
            Description = @"",
        };
        public GetOrganizationCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the organization details by its ID.")
        {
            _client = client;

            Arguments.Add(OrganizationId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.GetOrganizationAsync(
                organizationId: organizationId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}