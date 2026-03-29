//HintName: G.Models.ListUsageLimitsPolicyEntitiesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListUsageLimitsPolicyEntitiesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exhausted")]
        Exhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListUsageLimitsPolicyEntitiesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListUsageLimitsPolicyEntitiesStatus value)
        {
            return value switch
            {
                ListUsageLimitsPolicyEntitiesStatus.Active => "active",
                ListUsageLimitsPolicyEntitiesStatus.Exhausted => "exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListUsageLimitsPolicyEntitiesStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListUsageLimitsPolicyEntitiesStatus.Active,
                "exhausted" => ListUsageLimitsPolicyEntitiesStatus.Exhausted,
                _ => null,
            };
        }
    }
}