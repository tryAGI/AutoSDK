//HintName: G.Commands.AppsGetBySlugCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsGetBySlugCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string appSlug,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Integration? response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AppSlug { get; } = new(
            name: "appSlug")
        {
            Description = "",
        };

        public AppsGetBySlugCommand(G.IApi client) : base(
            name: "apps",
            description: @"> [!NOTE]
> The `:app_slug` is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., `https://github.com/settings/apps/:app_slug`).")
        {
            _client = client;

            Arguments.Add(AppSlug);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var appSlug = parseResult.GetRequiredValue(AppSlug);

            Validate(
                parseResult: parseResult,
                appSlug: appSlug,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsGetBySlugAsync(
                appSlug: appSlug,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}