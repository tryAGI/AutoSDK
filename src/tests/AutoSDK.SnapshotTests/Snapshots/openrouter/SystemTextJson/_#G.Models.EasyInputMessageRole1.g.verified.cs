//HintName: G.Models.EasyInputMessageRole1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessageRole1
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRole1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole1 value)
        {
            return value switch
            {
                EasyInputMessageRole1.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRole1? ToEnum(string value)
        {
            return value switch
            {
                "system" => EasyInputMessageRole1.System,
                _ => null,
            };
        }
    }
}