//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesUnlockedIssuePerformedViaGithubAppEvents.WorkflowRun,
                _ => null,
            };
        }
    }
}