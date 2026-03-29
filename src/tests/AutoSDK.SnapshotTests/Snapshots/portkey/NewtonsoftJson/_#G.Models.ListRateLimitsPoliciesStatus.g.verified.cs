//HintName: G.Models.ListRateLimitsPoliciesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRateLimitsPoliciesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archived")]
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRateLimitsPoliciesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRateLimitsPoliciesStatus value)
        {
            return value switch
            {
                ListRateLimitsPoliciesStatus.Active => "active",
                ListRateLimitsPoliciesStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRateLimitsPoliciesStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListRateLimitsPoliciesStatus.Active,
                "archived" => ListRateLimitsPoliciesStatus.Archived,
                _ => null,
            };
        }
    }
}