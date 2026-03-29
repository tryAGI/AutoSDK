//HintName: G.Models.OutputMessageStatus0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessageStatus0
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageStatus0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageStatus0 value)
        {
            return value switch
            {
                OutputMessageStatus0.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageStatus0? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputMessageStatus0.Completed,
                _ => null,
            };
        }
    }
}