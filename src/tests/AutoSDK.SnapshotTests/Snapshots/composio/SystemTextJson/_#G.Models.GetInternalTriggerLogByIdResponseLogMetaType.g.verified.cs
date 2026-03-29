//HintName: G.Models.GetInternalTriggerLogByIdResponseLogMetaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log entity type (trigger or action)<br/>
    /// Example: trigger
    /// </summary>
    public enum GetInternalTriggerLogByIdResponseLogMetaType
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
    public static class GetInternalTriggerLogByIdResponseLogMetaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalTriggerLogByIdResponseLogMetaType value)
        {
            return value switch
            {
                GetInternalTriggerLogByIdResponseLogMetaType.Action => "action",
                GetInternalTriggerLogByIdResponseLogMetaType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalTriggerLogByIdResponseLogMetaType? ToEnum(string value)
        {
            return value switch
            {
                "action" => GetInternalTriggerLogByIdResponseLogMetaType.Action,
                "trigger" => GetInternalTriggerLogByIdResponseLogMetaType.Trigger,
                _ => null,
            };
        }
    }
}