//HintName: G.Models.BoxAuthMechanism.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BoxAuthMechanism
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ccg")]
        Ccg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer_token")]
        DeveloperToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoxAuthMechanismExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoxAuthMechanism value)
        {
            return value switch
            {
                BoxAuthMechanism.Ccg => "ccg",
                BoxAuthMechanism.DeveloperToken => "developer_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoxAuthMechanism? ToEnum(string value)
        {
            return value switch
            {
                "ccg" => BoxAuthMechanism.Ccg,
                "developer_token" => BoxAuthMechanism.DeveloperToken,
                _ => null,
            };
        }
    }
}