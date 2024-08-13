//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
    /// </summary>
    public enum ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath
    {
        /// <summary>
        /// 
        /// </summary>
        x,
        /// <summary>
        /// 
        /// </summary>
        Docs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateInformationAboutPagesSiteRequestSourceEnumPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath value)
        {
            return value switch
            {
                ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath.x => "/",
                ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath.Docs => "/docs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath? ToEnum(string value)
        {
            return value switch
            {
                "/" => ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath.x,
                "/docs" => ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath.Docs,
                _ => null,
            };
        }
    }
}