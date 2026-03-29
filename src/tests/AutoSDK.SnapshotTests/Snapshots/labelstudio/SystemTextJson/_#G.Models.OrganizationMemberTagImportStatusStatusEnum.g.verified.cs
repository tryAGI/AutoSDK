//HintName: G.Models.OrganizationMemberTagImportStatusStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `created` - Created<br/>
    /// * `in_progress` - In Progress<br/>
    /// * `completed` - Completed<br/>
    /// * `failed` - Failed
    /// </summary>
    public enum OrganizationMemberTagImportStatusStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationMemberTagImportStatusStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationMemberTagImportStatusStatusEnum value)
        {
            return value switch
            {
                OrganizationMemberTagImportStatusStatusEnum.Completed => "completed",
                OrganizationMemberTagImportStatusStatusEnum.Created => "created",
                OrganizationMemberTagImportStatusStatusEnum.Failed => "failed",
                OrganizationMemberTagImportStatusStatusEnum.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationMemberTagImportStatusStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OrganizationMemberTagImportStatusStatusEnum.Completed,
                "created" => OrganizationMemberTagImportStatusStatusEnum.Created,
                "failed" => OrganizationMemberTagImportStatusStatusEnum.Failed,
                "in_progress" => OrganizationMemberTagImportStatusStatusEnum.InProgress,
                _ => null,
            };
        }
    }
}