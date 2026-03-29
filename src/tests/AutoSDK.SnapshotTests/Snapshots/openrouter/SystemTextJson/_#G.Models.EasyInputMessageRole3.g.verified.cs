//HintName: G.Models.EasyInputMessageRole3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessageRole3
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole3 value)
        {
            return value switch
            {
                EasyInputMessageRole3.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRole3? ToEnum(string value)
        {
            return value switch
            {
                "developer" => EasyInputMessageRole3.Developer,
                _ => null,
            };
        }
    }
}