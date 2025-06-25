//HintName: G.Commands.ReposCreateDeploymentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateDeploymentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @ref,
            string? task,
            bool? autoMerge,
            global::System.Collections.Generic.IList<string>? requiredContexts,
            global::G.OneOf<object, string>? payload,
            string? environment,
            string? description,
            bool? transientEnvironment,
            bool? productionEnvironment,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Deployment response,
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

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Task { get; } = new(
            name: "task")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoMerge { get; } = new(
            name: "autoMerge")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RequiredContexts { get; } = new(
            name: "requiredContexts")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<object, string>?> Payload { get; } = new(
            name: "payload")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Environment { get; } = new(
            name: "environment")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> TransientEnvironment { get; } = new(
            name: "transientEnvironment")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ProductionEnvironment { get; } = new(
            name: "productionEnvironment")
        {
            Description = "",
        };
        public ReposCreateDeploymentCommand(G.IApi client) : base(
            name: "repos",
            description: @"Deployments offer a few configurable parameters with certain defaults.

The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them
before we merge a pull request.

The `environment` parameter allows deployments to be issued to different runtime environments. Teams often have
multiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parameter
makes it easier to track which environments have requested deployments. The default environment is `production`.

The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. If
the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,
the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will
return a failure response.

By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`
state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or to
specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do
not require any contexts or create any commit statuses, the deployment will always succeed.

The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON text
field that will be passed on when a deployment event is dispatched.

The `task` parameter is used by the deployment system to allow different execution paths. In the web world this might
be `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile an
application with debugging enabled.

Merged branch response:

You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating
a deployment. This auto-merge happens when:
*   Auto-merge option is enabled in the repository
*   Topic branch does not include the latest changes on the base branch, which is `master` in the response example
*   There are no merge conflicts

If there are no new commits in the base branch, a new request to create a deployment should give a successful
response.

Merge conflict response:

This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can't
be merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.

Failed commit status checks:

This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`
status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Ref);
            Options.Add(Task);
            Options.Add(AutoMerge);
            Options.Add(RequiredContexts);
            Options.Add(Payload);
            Options.Add(Environment);
            Options.Add(Description);
            Options.Add(TransientEnvironment);
            Options.Add(ProductionEnvironment);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var task = parseResult.GetRequiredValue(Task);
            var autoMerge = parseResult.GetRequiredValue(AutoMerge);
            var requiredContexts = parseResult.GetRequiredValue(RequiredContexts);
            var payload = parseResult.GetRequiredValue(Payload);
            var environment = parseResult.GetRequiredValue(Environment);
            var description = parseResult.GetRequiredValue(Description);
            var transientEnvironment = parseResult.GetRequiredValue(TransientEnvironment);
            var productionEnvironment = parseResult.GetRequiredValue(ProductionEnvironment);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                task: task,
                autoMerge: autoMerge,
                requiredContexts: requiredContexts,
                payload: payload,
                environment: environment,
                description: description,
                transientEnvironment: transientEnvironment,
                productionEnvironment: productionEnvironment,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateDeploymentAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                task: task,
                autoMerge: autoMerge,
                requiredContexts: requiredContexts,
                payload: payload,
                environment: environment,
                description: description,
                transientEnvironment: transientEnvironment,
                productionEnvironment: productionEnvironment,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}