//HintName: G.Commands.ReposGenerateReleaseNotesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGenerateReleaseNotesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string tagName,
            string? targetCommitish,
            string? previousTagName,
            string? configurationFilePath,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ReleaseNotesContent response,
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

        private global::System.CommandLine.Argument<string> TagName { get; } = new(
            name: "tagName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TargetCommitish { get; } = new(
            name: "targetCommitish")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PreviousTagName { get; } = new(
            name: "previousTagName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ConfigurationFilePath { get; } = new(
            name: "configurationFilePath")
        {
            Description = "",
        };
        public ReposGenerateReleaseNotesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Generate a name and body describing a [release](https://docs.github.com/rest/releases/releases#get-a-release). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(TagName);
            Options.Add(TargetCommitish);
            Options.Add(PreviousTagName);
            Options.Add(ConfigurationFilePath);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var tagName = parseResult.GetRequiredValue(TagName);
            var targetCommitish = parseResult.GetRequiredValue(TargetCommitish);
            var previousTagName = parseResult.GetRequiredValue(PreviousTagName);
            var configurationFilePath = parseResult.GetRequiredValue(ConfigurationFilePath);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                tagName: tagName,
                targetCommitish: targetCommitish,
                previousTagName: previousTagName,
                configurationFilePath: configurationFilePath,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGenerateReleaseNotesAsync(
                owner: owner,
                repo: repo,
                tagName: tagName,
                targetCommitish: targetCommitish,
                previousTagName: previousTagName,
                configurationFilePath: configurationFilePath,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}