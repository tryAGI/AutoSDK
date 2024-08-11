//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_protection_rule")]
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_run")]
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_suite")]
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning_alert")]
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_comment")]
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_reference")]
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment")]
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_review")]
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_status")]
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deploy_key")]
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion")]
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_comment")]
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fork")]
        Fork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gollum")]
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issues")]
        Issues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_comment")]
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="label")]
        Label,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="membership")]
        Membership,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="milestone")]
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_block")]
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_build")]
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_card")]
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_column")]
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review")]
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_comment")]
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registry_package")]
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="release")]
        Release,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository")]
        Repository,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_dispatch")]
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert")]
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="star")]
        Star,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team_add")]
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watch")]
        Watch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_dispatch")]
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_run")]
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