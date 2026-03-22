//HintName: G.Models.GitCreateTreeRequestTreeItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either `blob`, `tree`, or `commit`.
    /// </summary>
    public enum GitCreateTreeRequestTreeItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        Commit,
        /// <summary>
        /// 
        /// </summary>
        Tree,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitCreateTreeRequestTreeItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitCreateTreeRequestTreeItemType value)
        {
            return value switch
            {
                GitCreateTreeRequestTreeItemType.Blob => "blob",
                GitCreateTreeRequestTreeItemType.Commit => "commit",
                GitCreateTreeRequestTreeItemType.Tree => "tree",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitCreateTreeRequestTreeItemType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => GitCreateTreeRequestTreeItemType.Blob,
                "commit" => GitCreateTreeRequestTreeItemType.Commit,
                "tree" => GitCreateTreeRequestTreeItemType.Tree,
                _ => null,
            };
        }
    }
}