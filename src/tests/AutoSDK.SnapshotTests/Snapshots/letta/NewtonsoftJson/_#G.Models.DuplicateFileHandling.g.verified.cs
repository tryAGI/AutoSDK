//HintName: G.Models.DuplicateFileHandling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to handle duplicate filenames when uploading files
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DuplicateFileHandling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace")]
        Replace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skip")]
        Skip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="suffix")]
        Suffix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DuplicateFileHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DuplicateFileHandling value)
        {
            return value switch
            {
                DuplicateFileHandling.Error => "error",
                DuplicateFileHandling.Replace => "replace",
                DuplicateFileHandling.Skip => "skip",
                DuplicateFileHandling.Suffix => "suffix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DuplicateFileHandling? ToEnum(string value)
        {
            return value switch
            {
                "error" => DuplicateFileHandling.Error,
                "replace" => DuplicateFileHandling.Replace,
                "skip" => DuplicateFileHandling.Skip,
                "suffix" => DuplicateFileHandling.Suffix,
                _ => null,
            };
        }
    }
}