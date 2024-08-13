//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update the source for the repository. Must include the branch name, and may optionally specify the subdirectory `/docs`. Possible values are `"gh-pages"`, `"master"`, and `"master /docs"`.
    /// </summary>
    public enum ReposUpdateInformationAboutPagesSiteRequestSourceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        GhPages,
        /// <summary>
        /// 
        /// </summary>
        Master,
        /// <summary>
        /// 
        /// </summary>
        MasterDocs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateInformationAboutPagesSiteRequestSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInformationAboutPagesSiteRequestSourceEnum value)
        {
            return value switch
            {
                ReposUpdateInformationAboutPagesSiteRequestSourceEnum.GhPages => "gh-pages",
                ReposUpdateInformationAboutPagesSiteRequestSourceEnum.Master => "master",
                ReposUpdateInformationAboutPagesSiteRequestSourceEnum.MasterDocs => "master /docs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInformationAboutPagesSiteRequestSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "gh-pages" => ReposUpdateInformationAboutPagesSiteRequestSourceEnum.GhPages,
                "master" => ReposUpdateInformationAboutPagesSiteRequestSourceEnum.Master,
                "master /docs" => ReposUpdateInformationAboutPagesSiteRequestSourceEnum.MasterDocs,
                _ => null,
            };
        }
    }
}