//HintName: G.Models.ClientToolConfigInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: client
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientToolConfigInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolConfigInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolConfigInputType value)
        {
            return value switch
            {
                ClientToolConfigInputType.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolConfigInputType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ClientToolConfigInputType.Client,
                _ => null,
            };
        }
    }
}