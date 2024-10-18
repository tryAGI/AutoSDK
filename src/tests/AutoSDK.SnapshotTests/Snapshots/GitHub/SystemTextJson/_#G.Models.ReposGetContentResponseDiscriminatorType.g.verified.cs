//HintName: G.Models.ReposGetContentResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposGetContentResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Symlink,
        /// <summary>
        /// 
        /// </summary>
        Submodule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetContentResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetContentResponseDiscriminatorType value)
        {
            return value switch
            {
                ReposGetContentResponseDiscriminatorType.Array => "array",
                ReposGetContentResponseDiscriminatorType.File => "file",
                ReposGetContentResponseDiscriminatorType.Symlink => "symlink",
                ReposGetContentResponseDiscriminatorType.Submodule => "submodule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetContentResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ReposGetContentResponseDiscriminatorType.Array,
                "file" => ReposGetContentResponseDiscriminatorType.File,
                "symlink" => ReposGetContentResponseDiscriminatorType.Symlink,
                "submodule" => ReposGetContentResponseDiscriminatorType.Submodule,
                _ => null,
            };
        }
    }
}