//HintName: G.Models.MigrationsSetLfsPreferenceRequestUseLfs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsSetLfsPreferenceRequestUseLfs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opt_in")]
        OptIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opt_out")]
        OptOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsSetLfsPreferenceRequestUseLfsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsSetLfsPreferenceRequestUseLfs value)
        {
            return value switch
            {
                MigrationsSetLfsPreferenceRequestUseLfs.OptIn => "opt_in",
                MigrationsSetLfsPreferenceRequestUseLfs.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsSetLfsPreferenceRequestUseLfs ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => MigrationsSetLfsPreferenceRequestUseLfs.OptIn,
                "opt_out" => MigrationsSetLfsPreferenceRequestUseLfs.OptOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}