//HintName: G.Models.GetAuthConfigsByNanoidResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the authentication configuration
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAuthConfigsByNanoidResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DISABLED")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENABLED")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuthConfigsByNanoidResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsByNanoidResponseStatus value)
        {
            return value switch
            {
                GetAuthConfigsByNanoidResponseStatus.Disabled => "DISABLED",
                GetAuthConfigsByNanoidResponseStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsByNanoidResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => GetAuthConfigsByNanoidResponseStatus.Disabled,
                "ENABLED" => GetAuthConfigsByNanoidResponseStatus.Enabled,
                _ => null,
            };
        }
    }
}