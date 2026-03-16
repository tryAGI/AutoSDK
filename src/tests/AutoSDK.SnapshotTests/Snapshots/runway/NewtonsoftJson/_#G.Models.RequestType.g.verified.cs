//HintName: G.Models.RequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of upload to create
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestType value)
        {
            return value switch
            {
                RequestType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => RequestType.Ephemeral,
                _ => null,
            };
        }
    }
}