//HintName: G.Models.OpenAIFileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `file`.
    /// </summary>
    public enum OpenAIFileObject
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileObject value)
        {
            return value switch
            {
                OpenAIFileObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileObject ToEnum(string value)
        {
            return value switch
            {
                "file" => OpenAIFileObject.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}