//HintName: G.Models.OrgsListOutsideCollaboratorsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListOutsideCollaboratorsFilter
    {
        /// <summary>
        /// //github.com/blog/1614-two-factor-authentication) enabled will be returned.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2fa_disabled")]
        x2faDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListOutsideCollaboratorsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListOutsideCollaboratorsFilter value)
        {
            return value switch
            {
                OrgsListOutsideCollaboratorsFilter.x2faDisabled => "2fa_disabled",
                OrgsListOutsideCollaboratorsFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListOutsideCollaboratorsFilter? ToEnum(string value)
        {
            return value switch
            {
                "2fa_disabled" => OrgsListOutsideCollaboratorsFilter.x2faDisabled,
                "all" => OrgsListOutsideCollaboratorsFilter.All,
                _ => null,
            };
        }
    }
}