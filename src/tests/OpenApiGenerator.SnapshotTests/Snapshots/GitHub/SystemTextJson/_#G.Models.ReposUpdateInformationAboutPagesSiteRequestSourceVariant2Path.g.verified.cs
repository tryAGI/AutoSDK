//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
    /// </summary>
    public enum ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path
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
    public static class ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path value)
        {
            return value switch
            {
                ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.x => "/",
                ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.Docs => "/docs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path? ToEnum(string value)
        {
            return value switch
            {
                "/" => ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.x,
                "/docs" => ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path.Docs,
                _ => null,
            };
        }
    }
}