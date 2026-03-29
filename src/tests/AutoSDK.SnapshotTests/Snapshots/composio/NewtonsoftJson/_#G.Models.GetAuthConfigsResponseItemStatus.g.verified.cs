//HintName: G.Models.GetAuthConfigsResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the authentication configuration
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAuthConfigsResponseItemStatus
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
    public static class GetAuthConfigsResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsResponseItemStatus value)
        {
            return value switch
            {
                GetAuthConfigsResponseItemStatus.Disabled => "DISABLED",
                GetAuthConfigsResponseItemStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => GetAuthConfigsResponseItemStatus.Disabled,
                "ENABLED" => GetAuthConfigsResponseItemStatus.Enabled,
                _ => null,
            };
        }
    }
}