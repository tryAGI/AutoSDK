//HintName: G.Commands.UpdateOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            string? id,
            global::G.OrganizationProfile profile,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateOrganizationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OrganizationProfile> Profile { get; } = new(
            name: "profile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };
        public UpdateOrganizationCommand(G.IApi client) : base(
            name: "update",
            description: @"Accesses and updates an organization by ID.

In REST requests, only the supplied organization fields will be taken into
account when updating the resource.")
        {
            _client = client;

            Arguments.Add(OrganizationId);
            Arguments.Add(Profile);
            Options.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var id = parseResult.GetRequiredValue(Id);
            var profile = parseResult.GetRequiredValue(Profile);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                id: id,
                profile: profile,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.UpdateOrganizationAsync(
                organizationId: organizationId,
                id: id,
                profile: profile,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}