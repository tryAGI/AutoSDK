//HintName: G.Commands.SecurityAdvisoriesGetGlobalAdvisoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesGetGlobalAdvisoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string ghsaId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GlobalAdvisory response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GhsaId { get; } = new(
            name: "ghsaId")
        {
            Description = "",
        };

        public SecurityAdvisoriesGetGlobalAdvisoryCommand(G.IApi client) : base(
            name: "security",
            description: @"Gets a global security advisory using its GitHub Security Advisory (GHSA) identifier.")
        {
            _client = client;

            Arguments.Add(GhsaId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ghsaId = parseResult.GetRequiredValue(GhsaId);

            Validate(
                parseResult: parseResult,
                ghsaId: ghsaId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesGetGlobalAdvisoryAsync(
                ghsaId: ghsaId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}