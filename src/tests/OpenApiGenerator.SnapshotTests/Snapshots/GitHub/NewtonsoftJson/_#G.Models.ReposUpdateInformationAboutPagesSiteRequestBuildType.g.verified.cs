//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestBuildType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateInformationAboutPagesSiteRequestBuildType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateInformationAboutPagesSiteRequestBuildTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInformationAboutPagesSiteRequestBuildType value)
        {
            return value switch
            {
                ReposUpdateInformationAboutPagesSiteRequestBuildType.Legacy => "legacy",
                ReposUpdateInformationAboutPagesSiteRequestBuildType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInformationAboutPagesSiteRequestBuildType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => ReposUpdateInformationAboutPagesSiteRequestBuildType.Legacy,
                "workflow" => ReposUpdateInformationAboutPagesSiteRequestBuildType.Workflow,
                _ => null,
            };
        }
    }
}