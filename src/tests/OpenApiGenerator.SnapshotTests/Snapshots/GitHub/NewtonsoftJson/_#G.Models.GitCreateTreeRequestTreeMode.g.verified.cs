//HintName: G.Models.GitCreateTreeRequestTreeMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GitCreateTreeRequestTreeMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100644")]
        _100644,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100755")]
        _100755,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="040000")]
        _040000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="160000")]
        _160000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="120000")]
        _120000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitCreateTreeRequestTreeModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitCreateTreeRequestTreeMode value)
        {
            return value switch
            {
                GitCreateTreeRequestTreeMode._100644 => "100644",
                GitCreateTreeRequestTreeMode._100755 => "100755",
                GitCreateTreeRequestTreeMode._040000 => "040000",
                GitCreateTreeRequestTreeMode._160000 => "160000",
                GitCreateTreeRequestTreeMode._120000 => "120000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitCreateTreeRequestTreeMode? ToEnum(string value)
        {
            return value switch
            {
                "100644" => GitCreateTreeRequestTreeMode._100644,
                "100755" => GitCreateTreeRequestTreeMode._100755,
                "040000" => GitCreateTreeRequestTreeMode._040000,
                "160000" => GitCreateTreeRequestTreeMode._160000,
                "120000" => GitCreateTreeRequestTreeMode._120000,
                _ => null,
            };
        }
    }
}