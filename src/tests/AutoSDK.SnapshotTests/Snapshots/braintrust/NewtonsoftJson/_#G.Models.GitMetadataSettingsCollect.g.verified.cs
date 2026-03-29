//HintName: G.Models.GitMetadataSettingsCollect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GitMetadataSettingsCollect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="some")]
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitMetadataSettingsCollectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitMetadataSettingsCollect value)
        {
            return value switch
            {
                GitMetadataSettingsCollect.All => "all",
                GitMetadataSettingsCollect.None => "none",
                GitMetadataSettingsCollect.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitMetadataSettingsCollect? ToEnum(string value)
        {
            return value switch
            {
                "all" => GitMetadataSettingsCollect.All,
                "none" => GitMetadataSettingsCollect.None,
                "some" => GitMetadataSettingsCollect.Some,
                _ => null,
            };
        }
    }
}