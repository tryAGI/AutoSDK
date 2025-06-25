//HintName: G.Commands.AppsCreateFromManifestCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsCreateFromManifestCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string code,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AllOf<global::G.Integration, global::G.AppsCreateFromManifestResponse2> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Code { get; } = new(
            name: "code")
        {
            Description = "",
        };

        public AppsCreateFromManifestCommand(G.IApi client) : base(
            name: "apps",
            description: @"Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary `code` used to retrieve the GitHub App's `id`, `pem` (private key), and `webhook_secret`.")
        {
            _client = client;

            Arguments.Add(Code);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var code = parseResult.GetRequiredValue(Code);

            Validate(
                parseResult: parseResult,
                code: code,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsCreateFromManifestAsync(
                code: code,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}