//HintName: G.Models.MediaVariableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: media_variable
    /// </summary>
    public enum MediaVariableType
    {
        /// <summary>
        /// 
        /// </summary>
        MediaVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaVariableType value)
        {
            return value switch
            {
                MediaVariableType.MediaVariable => "media_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaVariableType? ToEnum(string value)
        {
            return value switch
            {
                "media_variable" => MediaVariableType.MediaVariable,
                _ => null,
            };
        }
    }
}