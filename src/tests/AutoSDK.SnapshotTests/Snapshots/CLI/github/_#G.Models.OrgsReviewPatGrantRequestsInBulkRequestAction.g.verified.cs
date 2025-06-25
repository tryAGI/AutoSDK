﻿//HintName: G.Models.OrgsReviewPatGrantRequestsInBulkRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to apply to the requests.
    /// </summary>
    public enum OrgsReviewPatGrantRequestsInBulkRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Approve,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsReviewPatGrantRequestsInBulkRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsReviewPatGrantRequestsInBulkRequestAction value)
        {
            return value switch
            {
                OrgsReviewPatGrantRequestsInBulkRequestAction.Approve => "approve",
                OrgsReviewPatGrantRequestsInBulkRequestAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsReviewPatGrantRequestsInBulkRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "approve" => OrgsReviewPatGrantRequestsInBulkRequestAction.Approve,
                "deny" => OrgsReviewPatGrantRequestsInBulkRequestAction.Deny,
                _ => null,
            };
        }
    }
}