﻿//HintName: G.IReposClient.ReposCreateDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a deployment<br/>
        /// Deployments offer a few configurable parameters with certain defaults.<br/>
        /// The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them<br/>
        /// before we merge a pull request.<br/>
        /// The `environment` parameter allows deployments to be issued to different runtime environments. Teams often have<br/>
        /// multiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parameter<br/>
        /// makes it easier to track which environments have requested deployments. The default environment is `production`.<br/>
        /// The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. If<br/>
        /// the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,<br/>
        /// the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will<br/>
        /// return a failure response.<br/>
        /// By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`<br/>
        /// state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or to<br/>
        /// specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do<br/>
        /// not require any contexts or create any commit statuses, the deployment will always succeed.<br/>
        /// The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON text<br/>
        /// field that will be passed on when a deployment event is dispatched.<br/>
        /// The `task` parameter is used by the deployment system to allow different execution paths. In the web world this might<br/>
        /// be `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile an<br/>
        /// application with debugging enabled.<br/>
        /// Merged branch response:<br/>
        /// You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating<br/>
        /// a deployment. This auto-merge happens when:<br/>
        /// *   Auto-merge option is enabled in the repository<br/>
        /// *   Topic branch does not include the latest changes on the base branch, which is `master` in the response example<br/>
        /// *   There are no merge conflicts<br/>
        /// If there are no new commits in the base branch, a new request to create a deployment should give a successful<br/>
        /// response.<br/>
        /// Merge conflict response:<br/>
        /// This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can't<br/>
        /// be merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.<br/>
        /// Failed commit status checks:<br/>
        /// This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`<br/>
        /// status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Deployment> ReposCreateDeploymentAsync(
            string owner,
            string repo,
            global::G.ReposCreateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a deployment<br/>
        /// Deployments offer a few configurable parameters with certain defaults.<br/>
        /// The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them<br/>
        /// before we merge a pull request.<br/>
        /// The `environment` parameter allows deployments to be issued to different runtime environments. Teams often have<br/>
        /// multiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parameter<br/>
        /// makes it easier to track which environments have requested deployments. The default environment is `production`.<br/>
        /// The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. If<br/>
        /// the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,<br/>
        /// the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will<br/>
        /// return a failure response.<br/>
        /// By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`<br/>
        /// state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or to<br/>
        /// specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do<br/>
        /// not require any contexts or create any commit statuses, the deployment will always succeed.<br/>
        /// The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON text<br/>
        /// field that will be passed on when a deployment event is dispatched.<br/>
        /// The `task` parameter is used by the deployment system to allow different execution paths. In the web world this might<br/>
        /// be `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile an<br/>
        /// application with debugging enabled.<br/>
        /// Merged branch response:<br/>
        /// You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating<br/>
        /// a deployment. This auto-merge happens when:<br/>
        /// *   Auto-merge option is enabled in the repository<br/>
        /// *   Topic branch does not include the latest changes on the base branch, which is `master` in the response example<br/>
        /// *   There are no merge conflicts<br/>
        /// If there are no new commits in the base branch, a new request to create a deployment should give a successful<br/>
        /// response.<br/>
        /// Merge conflict response:<br/>
        /// This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can't<br/>
        /// be merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.<br/>
        /// Failed commit status checks:<br/>
        /// This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`<br/>
        /// status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// The ref to deploy. This can be a branch, tag, or SHA.
        /// </param>
        /// <param name="task">
        /// Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).<br/>
        /// Default Value: deploy
        /// </param>
        /// <param name="autoMerge">
        /// Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requiredContexts">
        /// The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="environment">
        /// Name for the target deployment environment (e.g., `production`, `staging`, `qa`).<br/>
        /// Default Value: production
        /// </param>
        /// <param name="description">
        /// Short description of the deployment.
        /// </param>
        /// <param name="transientEnvironment">
        /// Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="productionEnvironment">
        /// Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Deployment> ReposCreateDeploymentAsync(
            string owner,
            string repo,
            string @ref,
            string? task = default,
            bool? autoMerge = default,
            global::System.Collections.Generic.IList<string>? requiredContexts = default,
            global::G.OneOf<object, string>? payload = default,
            string? environment = default,
            string? description = default,
            bool? transientEnvironment = default,
            bool? productionEnvironment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}