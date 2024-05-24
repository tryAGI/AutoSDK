//HintName: G.Models.ProjectOrganizationPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
    /// </summary>
    public abstract class ProjectOrganizationPermission
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Read = "read";
        /// <summary>
        /// 
        /// </summary>
        public const string Write = "write";
        /// <summary>
        /// 
        /// </summary>
        public const string Admin = "admin";
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
    }
}