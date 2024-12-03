//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent
    {
        /// <summary>
        /// 
        /// </summary>
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        Fork,
        /// <summary>
        /// 
        /// </summary>
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        Issues,
        /// <summary>
        /// 
        /// </summary>
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        Label,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Membership,
        /// <summary>
        /// 
        /// </summary>
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        Release,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        Star,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        Watch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}