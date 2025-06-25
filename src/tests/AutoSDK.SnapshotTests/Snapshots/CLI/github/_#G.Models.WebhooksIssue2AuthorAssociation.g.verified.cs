﻿//HintName: G.Models.WebhooksIssue2AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksIssue2AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssue2AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksIssue2AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksIssue2AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksIssue2AuthorAssociation.MEMBER => "MEMBER",
                WebhooksIssue2AuthorAssociation.NONE => "NONE",
                WebhooksIssue2AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssue2AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksIssue2AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksIssue2AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksIssue2AuthorAssociation.MEMBER,
                "NONE" => WebhooksIssue2AuthorAssociation.NONE,
                "OWNER" => WebhooksIssue2AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}