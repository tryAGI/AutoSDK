//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}