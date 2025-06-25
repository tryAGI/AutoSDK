//HintName: G.Models.UsageCompletionsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageCompletionsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageCompletionsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCompletionsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCompletionsResultObject value)
        {
            return value switch
            {
                UsageCompletionsResultObject.OrganizationUsageCompletionsResult => "organization.usage.completions.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCompletionsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.completions.result" => UsageCompletionsResultObject.OrganizationUsageCompletionsResult,
                _ => null,
            };
        }
    }
}