//HintName: G.Models.GetAnalyticsGroupsUsersResponseDataItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGroupsUsersResponseDataItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsUsersResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsUsersResponseDataItemObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsUsersResponseDataItemObject.AnalyticsGroup => "analytics-group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsUsersResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-group" => GetAnalyticsGroupsUsersResponseDataItemObject.AnalyticsGroup,
                _ => null,
            };
        }
    }
}