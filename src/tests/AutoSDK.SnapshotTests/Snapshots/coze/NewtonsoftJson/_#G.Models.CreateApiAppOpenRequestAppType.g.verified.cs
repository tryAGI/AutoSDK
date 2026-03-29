//HintName: G.Models.CreateApiAppOpenRequestAppType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 必填
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateApiAppOpenRequestAppType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="connector")]
        Connector,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiAppOpenRequestAppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiAppOpenRequestAppType value)
        {
            return value switch
            {
                CreateApiAppOpenRequestAppType.Connector => "connector",
                CreateApiAppOpenRequestAppType.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiAppOpenRequestAppType? ToEnum(string value)
        {
            return value switch
            {
                "connector" => CreateApiAppOpenRequestAppType.Connector,
                "normal" => CreateApiAppOpenRequestAppType.Normal,
                _ => null,
            };
        }
    }
}