//HintName: G.Models.BranchProtectionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchProtectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AdminPermsRequired,
        /// <summary>
        /// 
        /// </summary>
        WriterPermsRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchProtectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchProtectionStatus value)
        {
            return value switch
            {
                BranchProtectionStatus.AdminPermsRequired => "admin_perms_required",
                BranchProtectionStatus.WriterPermsRequired => "writer_perms_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchProtectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "admin_perms_required" => BranchProtectionStatus.AdminPermsRequired,
                "writer_perms_required" => BranchProtectionStatus.WriterPermsRequired,
                _ => null,
            };
        }
    }
}