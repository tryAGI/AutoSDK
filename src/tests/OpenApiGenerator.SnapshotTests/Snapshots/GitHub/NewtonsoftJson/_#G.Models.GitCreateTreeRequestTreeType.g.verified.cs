//HintName: G.Models.GitCreateTreeRequestTreeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either `blob`, `tree`, or `commit`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GitCreateTreeRequestTreeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blob")]
        Blob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tree")]
        Tree,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit")]
        Commit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitCreateTreeRequestTreeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitCreateTreeRequestTreeType value)
        {
            return value switch
            {
                GitCreateTreeRequestTreeType.Blob => "blob",
                GitCreateTreeRequestTreeType.Tree => "tree",
                GitCreateTreeRequestTreeType.Commit => "commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitCreateTreeRequestTreeType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => GitCreateTreeRequestTreeType.Blob,
                "tree" => GitCreateTreeRequestTreeType.Tree,
                "commit" => GitCreateTreeRequestTreeType.Commit,
                _ => null,
            };
        }
    }
}