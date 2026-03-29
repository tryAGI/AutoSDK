//HintName: G.Models.LogRequestOutputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogRequestOutputDiscriminatorType
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
    public static class LogRequestOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestOutputDiscriminatorType value)
        {
            return value switch
            {
                LogRequestOutputDiscriminatorType.Chat => "chat",
                LogRequestOutputDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => LogRequestOutputDiscriminatorType.Chat,
                "completion" => LogRequestOutputDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}