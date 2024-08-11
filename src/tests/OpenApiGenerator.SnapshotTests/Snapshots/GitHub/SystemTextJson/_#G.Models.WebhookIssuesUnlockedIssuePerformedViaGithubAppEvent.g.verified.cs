//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}