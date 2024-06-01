//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppEvents.WorkflowRun,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}