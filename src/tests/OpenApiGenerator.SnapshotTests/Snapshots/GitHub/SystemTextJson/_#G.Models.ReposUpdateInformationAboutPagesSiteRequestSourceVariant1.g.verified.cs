//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update the source for the repository. Must include the branch name, and may optionally specify the subdirectory `/docs`. Possible values are `"gh-pages"`, `"master"`, and `"master /docs"`.
    /// </summary>
    public enum ReposUpdateInformationAboutPagesSiteRequestSourceVariant1
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
    public static class ReposUpdateInformationAboutPagesSiteRequestSourceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInformationAboutPagesSiteRequestSourceVariant1 value)
        {
            return value switch
            {
                ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.GhPages => "gh-pages",
                ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.Master => "master",
                ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.MasterDocs => "master /docs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInformationAboutPagesSiteRequestSourceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "gh-pages" => ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.GhPages,
                "master" => ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.Master,
                "master /docs" => ReposUpdateInformationAboutPagesSiteRequestSourceVariant1.MasterDocs,
                _ => null,
            };
        }
    }
}