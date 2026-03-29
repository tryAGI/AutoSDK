//HintName: G.Models.PostCliCodactFailuresRequestFailureType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of codact failure being recorded.<br/>
    /// Example: wrong_tool_slug
    /// </summary>
    public enum PostCliCodactFailuresRequestFailureType
    {
        /// <summary>
        /// 
        /// </summary>
        WrongToolInputParam,
        /// <summary>
        /// 
        /// </summary>
        WrongToolSlug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCliCodactFailuresRequestFailureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCodactFailuresRequestFailureType value)
        {
            return value switch
            {
                PostCliCodactFailuresRequestFailureType.WrongToolInputParam => "wrong_tool_input_param",
                PostCliCodactFailuresRequestFailureType.WrongToolSlug => "wrong_tool_slug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCodactFailuresRequestFailureType? ToEnum(string value)
        {
            return value switch
            {
                "wrong_tool_input_param" => PostCliCodactFailuresRequestFailureType.WrongToolInputParam,
                "wrong_tool_slug" => PostCliCodactFailuresRequestFailureType.WrongToolSlug,
                _ => null,
            };
        }
    }
}