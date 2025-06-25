//HintName: G.Commands.GetContentClassificationLabelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetContentClassificationLabelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? locale,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetContentClassificationLabelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Locale { get; } = new(
            name: "locale")
        {
            Description = @"",
        };
        public GetContentClassificationLabelsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets information about Twitch content classification labels.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

            Options.Add(Locale);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var locale = parseResult.GetRequiredValue(Locale);

            Validate(
                parseResult: parseResult,
                locale: locale,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CCLs.GetContentClassificationLabelsAsync(
                locale: locale,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}