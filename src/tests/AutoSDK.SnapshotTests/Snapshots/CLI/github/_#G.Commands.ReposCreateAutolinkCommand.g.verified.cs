//HintName: G.Commands.ReposCreateAutolinkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateAutolinkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string keyPrefix,
            string urlTemplate,
            bool? isAlphanumeric,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Autolink response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> KeyPrefix { get; } = new(
            name: "keyPrefix")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UrlTemplate { get; } = new(
            name: "urlTemplate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsAlphanumeric { get; } = new(
            name: "isAlphanumeric")
        {
            Description = "",
        };
        public ReposCreateAutolinkCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with admin access to the repository can create an autolink.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(KeyPrefix);
            Arguments.Add(UrlTemplate);
            Options.Add(IsAlphanumeric);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var keyPrefix = parseResult.GetRequiredValue(KeyPrefix);
            var urlTemplate = parseResult.GetRequiredValue(UrlTemplate);
            var isAlphanumeric = parseResult.GetRequiredValue(IsAlphanumeric);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                keyPrefix: keyPrefix,
                urlTemplate: urlTemplate,
                isAlphanumeric: isAlphanumeric,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateAutolinkAsync(
                owner: owner,
                repo: repo,
                keyPrefix: keyPrefix,
                urlTemplate: urlTemplate,
                isAlphanumeric: isAlphanumeric,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}