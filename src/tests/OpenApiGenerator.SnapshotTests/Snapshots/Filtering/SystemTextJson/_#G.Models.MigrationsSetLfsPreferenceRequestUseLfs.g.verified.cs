//HintName: G.Models.MigrationsSetLfsPreferenceRequestUseLfs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
    /// </summary>
    public enum MigrationsSetLfsPreferenceRequestUseLfs
    {
        /// <summary>
        /// 
        /// </summary>
        OptIn,
        /// <summary>
        /// 
        /// </summary>
        OptOut,
    }

    public static class MigrationsSetLfsPreferenceRequestUseLfsExtensions
    {
        public static string ToValueString(this MigrationsSetLfsPreferenceRequestUseLfs value)
        {
            return value switch
            {
                MigrationsSetLfsPreferenceRequestUseLfs.OptIn => "opt_in",
                MigrationsSetLfsPreferenceRequestUseLfs.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsSetLfsPreferenceRequestUseLfs ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => MigrationsSetLfsPreferenceRequestUseLfs.OptIn,
                "opt_out" => MigrationsSetLfsPreferenceRequestUseLfs.OptOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsSetLfsPreferenceRequestUseLfs ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsSetLfsPreferenceRequestUseLfs.OptIn,
                1 => MigrationsSetLfsPreferenceRequestUseLfs.OptOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}