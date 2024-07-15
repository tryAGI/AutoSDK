//HintName: G.Models.OrgsReviewPatGrantRequestRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to apply to the request.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsReviewPatGrantRequestRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approve")]
        Approve,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deny")]
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsReviewPatGrantRequestRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsReviewPatGrantRequestRequestAction value)
        {
            return value switch
            {
                OrgsReviewPatGrantRequestRequestAction.Approve => "approve",
                OrgsReviewPatGrantRequestRequestAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsReviewPatGrantRequestRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "approve" => OrgsReviewPatGrantRequestRequestAction.Approve,
                "deny" => OrgsReviewPatGrantRequestRequestAction.Deny,
                _ => null,
            };
        }
    }
}