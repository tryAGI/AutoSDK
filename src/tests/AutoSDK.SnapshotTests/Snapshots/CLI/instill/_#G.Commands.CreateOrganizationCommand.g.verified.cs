//HintName: G.Commands.CreateOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? id,
            global::G.OrganizationProfile profile,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateOrganizationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OrganizationProfile> Profile { get; } = new(
            name: "profile")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };
        public CreateOrganizationCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates an organization.")
        {
            _client = client;

            Arguments.Add(Profile);
            Options.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var profile = parseResult.GetRequiredValue(Profile);

            Validate(
                parseResult: parseResult,
                id: id,
                profile: profile,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.CreateOrganizationAsync(
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