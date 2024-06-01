//HintName: G.Models.ReposUpdateReleaseRequestMakeLatest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.
    /// <br/>Default Value: true
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateReleaseRequestMakeLatest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="true")]
        True,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false")]
        False,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateReleaseRequestMakeLatestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateReleaseRequestMakeLatest value)
        {
            return value switch
            {
                ReposUpdateReleaseRequestMakeLatest.True => "true",
                ReposUpdateReleaseRequestMakeLatest.False => "false",
                ReposUpdateReleaseRequestMakeLatest.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateReleaseRequestMakeLatest ToEnum(string value)
        {
            return value switch
            {
                "true" => ReposUpdateReleaseRequestMakeLatest.True,
                "false" => ReposUpdateReleaseRequestMakeLatest.False,
                "legacy" => ReposUpdateReleaseRequestMakeLatest.Legacy,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}