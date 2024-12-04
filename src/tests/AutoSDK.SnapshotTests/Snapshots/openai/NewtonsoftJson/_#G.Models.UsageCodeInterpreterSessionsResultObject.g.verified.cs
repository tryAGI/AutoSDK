//HintName: G.Models.UsageCodeInterpreterSessionsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageCodeInterpreterSessionsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.code_interpreter_sessions.result")]
        OrganizationUsageCodeInterpreterSessionsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCodeInterpreterSessionsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCodeInterpreterSessionsResultObject value)
        {
            return value switch
            {
                UsageCodeInterpreterSessionsResultObject.OrganizationUsageCodeInterpreterSessionsResult => "organization.usage.code_interpreter_sessions.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCodeInterpreterSessionsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.code_interpreter_sessions.result" => UsageCodeInterpreterSessionsResultObject.OrganizationUsageCodeInterpreterSessionsResult,
                _ => null,
            };
        }
    }
}