//HintName: G.Models.ReposCreateReleaseRequestMakeLatest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.
    /// <br/>Default Value: true
    /// </summary>
    public enum ReposCreateReleaseRequestMakeLatest
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateReleaseRequestMakeLatestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateReleaseRequestMakeLatest value)
        {
            return value switch
            {
                ReposCreateReleaseRequestMakeLatest.True => "true",
                ReposCreateReleaseRequestMakeLatest.False => "false",
                ReposCreateReleaseRequestMakeLatest.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateReleaseRequestMakeLatest ToEnum(string value)
        {
            return value switch
            {
                "true" => ReposCreateReleaseRequestMakeLatest.True,
                "false" => ReposCreateReleaseRequestMakeLatest.False,
                "legacy" => ReposCreateReleaseRequestMakeLatest.Legacy,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}