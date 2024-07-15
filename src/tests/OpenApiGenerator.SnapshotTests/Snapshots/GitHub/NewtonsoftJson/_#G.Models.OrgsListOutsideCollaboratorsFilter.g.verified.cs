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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2fa_disabled")]
        _2faDisabled,
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
                OrgsListOutsideCollaboratorsFilter._2faDisabled => "2fa_disabled",
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
                "2fa_disabled" => OrgsListOutsideCollaboratorsFilter._2faDisabled,
                "all" => OrgsListOutsideCollaboratorsFilter.All,
                _ => null,
            };
        }
    }
}