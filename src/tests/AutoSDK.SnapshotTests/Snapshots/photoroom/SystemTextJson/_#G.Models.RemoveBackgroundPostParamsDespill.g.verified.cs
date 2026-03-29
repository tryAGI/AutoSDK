//HintName: G.Models.RemoveBackgroundPostParamsDespill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
    /// Default Value: false
    /// </summary>
    public enum RemoveBackgroundPostParamsDespill
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveBackgroundPostParamsDespillExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveBackgroundPostParamsDespill value)
        {
            return value switch
            {
                RemoveBackgroundPostParamsDespill.False => "false",
                RemoveBackgroundPostParamsDespill.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveBackgroundPostParamsDespill? ToEnum(string value)
        {
            return value switch
            {
                "false" => RemoveBackgroundPostParamsDespill.False,
                "true" => RemoveBackgroundPostParamsDespill.True,
                _ => null,
            };
        }
    }
}