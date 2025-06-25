//HintName: G.Commands.ReposCreateUsingTemplateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateUsingTemplateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string templateOwner,
            string templateRepo,
            string? owner,
            string name,
            string? description,
            bool? includeAllBranches,
            bool? @private,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullRepository response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TemplateOwner { get; } = new(
            name: "templateOwner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TemplateRepo { get; } = new(
            name: "templateRepo")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IncludeAllBranches { get; } = new(
            name: "includeAllBranches")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = "",
        };
        public ReposCreateUsingTemplateCommand(G.IApi client) : base(
            name: "repos",
            description: @"Creates a new repository using a repository template. Use the `template_owner` and `template_repo` route parameters to specify the repository to use as the template. If the repository is not public, the authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository's information using the [Get a repository](https://docs.github.com/rest/repos/repos#get-a-repository) endpoint and check that the `is_template` key is `true`.

OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.")
        {
            _client = client;

            Arguments.Add(TemplateOwner);
            Arguments.Add(TemplateRepo);
            Arguments.Add(Name);
            Options.Add(Owner);
            Options.Add(Description);
            Options.Add(IncludeAllBranches);
            Options.Add(Private);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var templateOwner = parseResult.GetRequiredValue(TemplateOwner);
            var templateRepo = parseResult.GetRequiredValue(TemplateRepo);
            var owner = parseResult.GetRequiredValue(Owner);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var includeAllBranches = parseResult.GetRequiredValue(IncludeAllBranches);
            var @private = parseResult.GetRequiredValue(Private);

            Validate(
                parseResult: parseResult,
                templateOwner: templateOwner,
                templateRepo: templateRepo,
                owner: owner,
                name: name,
                description: description,
                includeAllBranches: includeAllBranches,
                @private: @private,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateUsingTemplateAsync(
                templateOwner: templateOwner,
                templateRepo: templateRepo,
                owner: owner,
                name: name,
                description: description,
                includeAllBranches: includeAllBranches,
                @private: @private,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}