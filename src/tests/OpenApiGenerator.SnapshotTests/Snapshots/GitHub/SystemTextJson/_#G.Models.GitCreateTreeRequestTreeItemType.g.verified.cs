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
        Tree,
        /// <summary>
        /// 
        /// </summary>
        Commit,
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
                GitCreateTreeRequestTreeItemType.Tree => "tree",
                GitCreateTreeRequestTreeItemType.Commit => "commit",
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
                "tree" => GitCreateTreeRequestTreeItemType.Tree,
                "commit" => GitCreateTreeRequestTreeItemType.Commit,
                _ => null,
            };
        }
    }
}