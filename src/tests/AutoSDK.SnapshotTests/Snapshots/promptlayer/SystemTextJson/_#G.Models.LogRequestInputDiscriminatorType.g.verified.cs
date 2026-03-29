//HintName: G.Models.LogRequestInputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogRequestInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogRequestInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestInputDiscriminatorType value)
        {
            return value switch
            {
                LogRequestInputDiscriminatorType.Chat => "chat",
                LogRequestInputDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => LogRequestInputDiscriminatorType.Chat,
                "completion" => LogRequestInputDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}