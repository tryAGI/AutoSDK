//HintName: G.Models.ListUsageLimitsPoliciesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListUsageLimitsPoliciesStatus
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
    public static class ListUsageLimitsPoliciesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListUsageLimitsPoliciesStatus value)
        {
            return value switch
            {
                ListUsageLimitsPoliciesStatus.Active => "active",
                ListUsageLimitsPoliciesStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListUsageLimitsPoliciesStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListUsageLimitsPoliciesStatus.Active,
                "archived" => ListUsageLimitsPoliciesStatus.Archived,
                _ => null,
            };
        }
    }
}