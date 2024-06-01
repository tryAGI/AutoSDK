//HintName: G.Models.WebhookMetaDeletedHookEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMetaDeletedHookEvents
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
    public static class WebhookMetaDeletedHookEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMetaDeletedHookEvents value)
        {
            return value switch
            {
                WebhookMetaDeletedHookEvents.Any => "*",
                WebhookMetaDeletedHookEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookMetaDeletedHookEvents.CheckRun => "check_run",
                WebhookMetaDeletedHookEvents.CheckSuite => "check_suite",
                WebhookMetaDeletedHookEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookMetaDeletedHookEvents.CommitComment => "commit_comment",
                WebhookMetaDeletedHookEvents.Create => "create",
                WebhookMetaDeletedHookEvents.Delete => "delete",
                WebhookMetaDeletedHookEvents.Deployment => "deployment",
                WebhookMetaDeletedHookEvents.DeploymentStatus => "deployment_status",
                WebhookMetaDeletedHookEvents.DeployKey => "deploy_key",
                WebhookMetaDeletedHookEvents.Discussion => "discussion",
                WebhookMetaDeletedHookEvents.DiscussionComment => "discussion_comment",
                WebhookMetaDeletedHookEvents.Fork => "fork",
                WebhookMetaDeletedHookEvents.Gollum => "gollum",
                WebhookMetaDeletedHookEvents.Issues => "issues",
                WebhookMetaDeletedHookEvents.IssueComment => "issue_comment",
                WebhookMetaDeletedHookEvents.Label => "label",
                WebhookMetaDeletedHookEvents.Member => "member",
                WebhookMetaDeletedHookEvents.Membership => "membership",
                WebhookMetaDeletedHookEvents.Meta => "meta",
                WebhookMetaDeletedHookEvents.Milestone => "milestone",
                WebhookMetaDeletedHookEvents.Organization => "organization",
                WebhookMetaDeletedHookEvents.OrgBlock => "org_block",
                WebhookMetaDeletedHookEvents.Package => "package",
                WebhookMetaDeletedHookEvents.PageBuild => "page_build",
                WebhookMetaDeletedHookEvents.Project => "project",
                WebhookMetaDeletedHookEvents.ProjectCard => "project_card",
                WebhookMetaDeletedHookEvents.ProjectColumn => "project_column",
                WebhookMetaDeletedHookEvents.Public => "public",
                WebhookMetaDeletedHookEvents.PullRequest => "pull_request",
                WebhookMetaDeletedHookEvents.PullRequestReview => "pull_request_review",
                WebhookMetaDeletedHookEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookMetaDeletedHookEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookMetaDeletedHookEvents.Push => "push",
                WebhookMetaDeletedHookEvents.RegistryPackage => "registry_package",
                WebhookMetaDeletedHookEvents.Release => "release",
                WebhookMetaDeletedHookEvents.Repository => "repository",
                WebhookMetaDeletedHookEvents.RepositoryImport => "repository_import",
                WebhookMetaDeletedHookEvents.RepositoryVulnerabilityAlert => "repository_vulnerability_alert",
                WebhookMetaDeletedHookEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookMetaDeletedHookEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookMetaDeletedHookEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookMetaDeletedHookEvents.Star => "star",
                WebhookMetaDeletedHookEvents.Status => "status",
                WebhookMetaDeletedHookEvents.Team => "team",
                WebhookMetaDeletedHookEvents.TeamAdd => "team_add",
                WebhookMetaDeletedHookEvents.Watch => "watch",
                WebhookMetaDeletedHookEvents.WorkflowJob => "workflow_job",
                WebhookMetaDeletedHookEvents.WorkflowRun => "workflow_run",
                WebhookMetaDeletedHookEvents.RepositoryDispatch => "repository_dispatch",
                WebhookMetaDeletedHookEvents.ProjectsV2Item => "projects_v2_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMetaDeletedHookEvents ToEnum(string value)
        {
            return value switch
            {
                "*" => WebhookMetaDeletedHookEvents.Any,
                "branch_protection_rule" => WebhookMetaDeletedHookEvents.BranchProtectionRule,
                "check_run" => WebhookMetaDeletedHookEvents.CheckRun,
                "check_suite" => WebhookMetaDeletedHookEvents.CheckSuite,
                "code_scanning_alert" => WebhookMetaDeletedHookEvents.CodeScanningAlert,
                "commit_comment" => WebhookMetaDeletedHookEvents.CommitComment,
                "create" => WebhookMetaDeletedHookEvents.Create,
                "delete" => WebhookMetaDeletedHookEvents.Delete,
                "deployment" => WebhookMetaDeletedHookEvents.Deployment,
                "deployment_status" => WebhookMetaDeletedHookEvents.DeploymentStatus,
                "deploy_key" => WebhookMetaDeletedHookEvents.DeployKey,
                "discussion" => WebhookMetaDeletedHookEvents.Discussion,
                "discussion_comment" => WebhookMetaDeletedHookEvents.DiscussionComment,
                "fork" => WebhookMetaDeletedHookEvents.Fork,
                "gollum" => WebhookMetaDeletedHookEvents.Gollum,
                "issues" => WebhookMetaDeletedHookEvents.Issues,
                "issue_comment" => WebhookMetaDeletedHookEvents.IssueComment,
                "label" => WebhookMetaDeletedHookEvents.Label,
                "member" => WebhookMetaDeletedHookEvents.Member,
                "membership" => WebhookMetaDeletedHookEvents.Membership,
                "meta" => WebhookMetaDeletedHookEvents.Meta,
                "milestone" => WebhookMetaDeletedHookEvents.Milestone,
                "organization" => WebhookMetaDeletedHookEvents.Organization,
                "org_block" => WebhookMetaDeletedHookEvents.OrgBlock,
                "package" => WebhookMetaDeletedHookEvents.Package,
                "page_build" => WebhookMetaDeletedHookEvents.PageBuild,
                "project" => WebhookMetaDeletedHookEvents.Project,
                "project_card" => WebhookMetaDeletedHookEvents.ProjectCard,
                "project_column" => WebhookMetaDeletedHookEvents.ProjectColumn,
                "public" => WebhookMetaDeletedHookEvents.Public,
                "pull_request" => WebhookMetaDeletedHookEvents.PullRequest,
                "pull_request_review" => WebhookMetaDeletedHookEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookMetaDeletedHookEvents.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookMetaDeletedHookEvents.PullRequestReviewThread,
                "push" => WebhookMetaDeletedHookEvents.Push,
                "registry_package" => WebhookMetaDeletedHookEvents.RegistryPackage,
                "release" => WebhookMetaDeletedHookEvents.Release,
                "repository" => WebhookMetaDeletedHookEvents.Repository,
                "repository_import" => WebhookMetaDeletedHookEvents.RepositoryImport,
                "repository_vulnerability_alert" => WebhookMetaDeletedHookEvents.RepositoryVulnerabilityAlert,
                "secret_scanning_alert" => WebhookMetaDeletedHookEvents.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookMetaDeletedHookEvents.SecretScanningAlertLocation,
                "security_and_analysis" => WebhookMetaDeletedHookEvents.SecurityAndAnalysis,
                "star" => WebhookMetaDeletedHookEvents.Star,
                "status" => WebhookMetaDeletedHookEvents.Status,
                "team" => WebhookMetaDeletedHookEvents.Team,
                "team_add" => WebhookMetaDeletedHookEvents.TeamAdd,
                "watch" => WebhookMetaDeletedHookEvents.Watch,
                "workflow_job" => WebhookMetaDeletedHookEvents.WorkflowJob,
                "workflow_run" => WebhookMetaDeletedHookEvents.WorkflowRun,
                "repository_dispatch" => WebhookMetaDeletedHookEvents.RepositoryDispatch,
                "projects_v2_item" => WebhookMetaDeletedHookEvents.ProjectsV2Item,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}