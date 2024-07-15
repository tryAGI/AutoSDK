//HintName: G.Models.GitCreateTagRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
    /// </summary>
    public enum GitCreateTagRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Commit,
        /// <summary>
        /// 
        /// </summary>
        Tree,
        /// <summary>
        /// 
        /// </summary>
        Blob,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitCreateTagRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitCreateTagRequestType value)
        {
            return value switch
            {
                GitCreateTagRequestType.Commit => "commit",
                GitCreateTagRequestType.Tree => "tree",
                GitCreateTagRequestType.Blob => "blob",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitCreateTagRequestType? ToEnum(string value)
        {
            return value switch
            {
                "commit" => GitCreateTagRequestType.Commit,
                "tree" => GitCreateTagRequestType.Tree,
                "blob" => GitCreateTagRequestType.Blob,
                _ => null,
            };
        }
    }
}