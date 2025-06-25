//HintName: G.Models.GitCreateTreeRequestTreeItemMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.
    /// </summary>
    public enum GitCreateTreeRequestTreeItemMode
    {
        /// <summary>
        /// 
        /// </summary>
        x100644,
        /// <summary>
        /// 
        /// </summary>
        x100755,
        /// <summary>
        /// 
        /// </summary>
        x040000,
        /// <summary>
        /// 
        /// </summary>
        x160000,
        /// <summary>
        /// 
        /// </summary>
        x120000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitCreateTreeRequestTreeItemModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitCreateTreeRequestTreeItemMode value)
        {
            return value switch
            {
                GitCreateTreeRequestTreeItemMode.x100644 => "100644",
                GitCreateTreeRequestTreeItemMode.x100755 => "100755",
                GitCreateTreeRequestTreeItemMode.x040000 => "040000",
                GitCreateTreeRequestTreeItemMode.x160000 => "160000",
                GitCreateTreeRequestTreeItemMode.x120000 => "120000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitCreateTreeRequestTreeItemMode? ToEnum(string value)
        {
            return value switch
            {
                "100644" => GitCreateTreeRequestTreeItemMode.x100644,
                "100755" => GitCreateTreeRequestTreeItemMode.x100755,
                "040000" => GitCreateTreeRequestTreeItemMode.x040000,
                "160000" => GitCreateTreeRequestTreeItemMode.x160000,
                "120000" => GitCreateTreeRequestTreeItemMode.x120000,
                _ => null,
            };
        }
    }
}