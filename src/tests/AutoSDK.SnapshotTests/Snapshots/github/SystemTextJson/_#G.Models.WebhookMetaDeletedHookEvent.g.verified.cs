//HintName: G.Models.WebhookMetaDeletedHookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMetaDeletedHookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
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
        Meta,
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
        Package,
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
        PullRequestReviewThread,
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
        RepositoryImport,
        /// <summary>
        /// 
        /// </summary>
        RepositoryVulnerabilityAlert,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        SecurityAndAnalysis,
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
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        ProjectsV2Item,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMetaDeletedHookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMetaDeletedHookEvent value)
        {
            return value switch
            {
                WebhookMetaDeletedHookEvent.Any => "*",
                WebhookMetaDeletedHookEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookMetaDeletedHookEvent.CheckRun => "check_run",
                WebhookMetaDeletedHookEvent.CheckSuite => "check_suite",
                WebhookMetaDeletedHookEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookMetaDeletedHookEvent.CommitComment => "commit_comment",
                WebhookMetaDeletedHookEvent.Create => "create",
                WebhookMetaDeletedHookEvent.Delete => "delete",
                WebhookMetaDeletedHookEvent.Deployment => "deployment",
                WebhookMetaDeletedHookEvent.DeploymentStatus => "deployment_status",
                WebhookMetaDeletedHookEvent.DeployKey => "deploy_key",
                WebhookMetaDeletedHookEvent.Discussion => "discussion",
                WebhookMetaDeletedHookEvent.DiscussionComment => "discussion_comment",
                WebhookMetaDeletedHookEvent.Fork => "fork",
                WebhookMetaDeletedHookEvent.Gollum => "gollum",
                WebhookMetaDeletedHookEvent.Issues => "issues",
                WebhookMetaDeletedHookEvent.IssueComment => "issue_comment",
                WebhookMetaDeletedHookEvent.Label => "label",
                WebhookMetaDeletedHookEvent.Member => "member",
                WebhookMetaDeletedHookEvent.Membership => "membership",
                WebhookMetaDeletedHookEvent.Meta => "meta",
                WebhookMetaDeletedHookEvent.Milestone => "milestone",
                WebhookMetaDeletedHookEvent.Organization => "organization",
                WebhookMetaDeletedHookEvent.OrgBlock => "org_block",
                WebhookMetaDeletedHookEvent.Package => "package",
                WebhookMetaDeletedHookEvent.PageBuild => "page_build",
                WebhookMetaDeletedHookEvent.Project => "project",
                WebhookMetaDeletedHookEvent.ProjectCard => "project_card",
                WebhookMetaDeletedHookEvent.ProjectColumn => "project_column",
                WebhookMetaDeletedHookEvent.Public => "public",
                WebhookMetaDeletedHookEvent.PullRequest => "pull_request",
                WebhookMetaDeletedHookEvent.PullRequestReview => "pull_request_review",
                WebhookMetaDeletedHookEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookMetaDeletedHookEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookMetaDeletedHookEvent.Push => "push",
                WebhookMetaDeletedHookEvent.RegistryPackage => "registry_package",
                WebhookMetaDeletedHookEvent.Release => "release",
                WebhookMetaDeletedHookEvent.Repository => "repository",
                WebhookMetaDeletedHookEvent.RepositoryImport => "repository_import",
                WebhookMetaDeletedHookEvent.RepositoryVulnerabilityAlert => "repository_vulnerability_alert",
                WebhookMetaDeletedHookEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookMetaDeletedHookEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookMetaDeletedHookEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookMetaDeletedHookEvent.Star => "star",
                WebhookMetaDeletedHookEvent.Status => "status",
                WebhookMetaDeletedHookEvent.Team => "team",
                WebhookMetaDeletedHookEvent.TeamAdd => "team_add",
                WebhookMetaDeletedHookEvent.Watch => "watch",
                WebhookMetaDeletedHookEvent.WorkflowJob => "workflow_job",
                WebhookMetaDeletedHookEvent.WorkflowRun => "workflow_run",
                WebhookMetaDeletedHookEvent.RepositoryDispatch => "repository_dispatch",
                WebhookMetaDeletedHookEvent.ProjectsV2Item => "projects_v2_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMetaDeletedHookEvent? ToEnum(string value)
        {
            return value switch
            {
                "*" => WebhookMetaDeletedHookEvent.Any,
                "branch_protection_rule" => WebhookMetaDeletedHookEvent.BranchProtectionRule,
                "check_run" => WebhookMetaDeletedHookEvent.CheckRun,
                "check_suite" => WebhookMetaDeletedHookEvent.CheckSuite,
                "code_scanning_alert" => WebhookMetaDeletedHookEvent.CodeScanningAlert,
                "commit_comment" => WebhookMetaDeletedHookEvent.CommitComment,
                "create" => WebhookMetaDeletedHookEvent.Create,
                "delete" => WebhookMetaDeletedHookEvent.Delete,
                "deployment" => WebhookMetaDeletedHookEvent.Deployment,
                "deployment_status" => WebhookMetaDeletedHookEvent.DeploymentStatus,
                "deploy_key" => WebhookMetaDeletedHookEvent.DeployKey,
                "discussion" => WebhookMetaDeletedHookEvent.Discussion,
                "discussion_comment" => WebhookMetaDeletedHookEvent.DiscussionComment,
                "fork" => WebhookMetaDeletedHookEvent.Fork,
                "gollum" => WebhookMetaDeletedHookEvent.Gollum,
                "issues" => WebhookMetaDeletedHookEvent.Issues,
                "issue_comment" => WebhookMetaDeletedHookEvent.IssueComment,
                "label" => WebhookMetaDeletedHookEvent.Label,
                "member" => WebhookMetaDeletedHookEvent.Member,
                "membership" => WebhookMetaDeletedHookEvent.Membership,
                "meta" => WebhookMetaDeletedHookEvent.Meta,
                "milestone" => WebhookMetaDeletedHookEvent.Milestone,
                "organization" => WebhookMetaDeletedHookEvent.Organization,
                "org_block" => WebhookMetaDeletedHookEvent.OrgBlock,
                "package" => WebhookMetaDeletedHookEvent.Package,
                "page_build" => WebhookMetaDeletedHookEvent.PageBuild,
                "project" => WebhookMetaDeletedHookEvent.Project,
                "project_card" => WebhookMetaDeletedHookEvent.ProjectCard,
                "project_column" => WebhookMetaDeletedHookEvent.ProjectColumn,
                "public" => WebhookMetaDeletedHookEvent.Public,
                "pull_request" => WebhookMetaDeletedHookEvent.PullRequest,
                "pull_request_review" => WebhookMetaDeletedHookEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookMetaDeletedHookEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookMetaDeletedHookEvent.PullRequestReviewThread,
                "push" => WebhookMetaDeletedHookEvent.Push,
                "registry_package" => WebhookMetaDeletedHookEvent.RegistryPackage,
                "release" => WebhookMetaDeletedHookEvent.Release,
                "repository" => WebhookMetaDeletedHookEvent.Repository,
                "repository_import" => WebhookMetaDeletedHookEvent.RepositoryImport,
                "repository_vulnerability_alert" => WebhookMetaDeletedHookEvent.RepositoryVulnerabilityAlert,
                "secret_scanning_alert" => WebhookMetaDeletedHookEvent.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookMetaDeletedHookEvent.SecretScanningAlertLocation,
                "security_and_analysis" => WebhookMetaDeletedHookEvent.SecurityAndAnalysis,
                "star" => WebhookMetaDeletedHookEvent.Star,
                "status" => WebhookMetaDeletedHookEvent.Status,
                "team" => WebhookMetaDeletedHookEvent.Team,
                "team_add" => WebhookMetaDeletedHookEvent.TeamAdd,
                "watch" => WebhookMetaDeletedHookEvent.Watch,
                "workflow_job" => WebhookMetaDeletedHookEvent.WorkflowJob,
                "workflow_run" => WebhookMetaDeletedHookEvent.WorkflowRun,
                "repository_dispatch" => WebhookMetaDeletedHookEvent.RepositoryDispatch,
                "projects_v2_item" => WebhookMetaDeletedHookEvent.ProjectsV2Item,
                _ => null,
            };
        }
    }
}