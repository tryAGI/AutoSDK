//HintName: G.Models.GetInternalTriggerLogByIdResponseLogType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log entity type (trigger or action)<br/>
    /// Example: trigger
    /// </summary>
    public enum GetInternalTriggerLogByIdResponseLogType
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInternalTriggerLogByIdResponseLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalTriggerLogByIdResponseLogType value)
        {
            return value switch
            {
                GetInternalTriggerLogByIdResponseLogType.Action => "action",
                GetInternalTriggerLogByIdResponseLogType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalTriggerLogByIdResponseLogType? ToEnum(string value)
        {
            return value switch
            {
                "action" => GetInternalTriggerLogByIdResponseLogType.Action,
                "trigger" => GetInternalTriggerLogByIdResponseLogType.Trigger,
                _ => null,
            };
        }
    }
}