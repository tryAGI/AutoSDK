//HintName: G.Models.V2CallBaseCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of call.<br/>
    /// - `registered`: Call id issued, starting to make a call using this id.<br/>
    /// - `ongoing`: Call connected and ongoing.<br/>
    /// - `ended`: The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.<br/>
    /// - `error`: Call encountered error.<br/>
    /// Example: registered
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V2CallBaseCallStatus
    {
        /// <summary>
        /// The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
        /// <summary>
        /// Call encountered error.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_connected")]
        NotConnected,
        /// <summary>
        /// Call connected and ongoing.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ongoing")]
        Ongoing,
        /// <summary>
        /// Call id issued, starting to make a call using this id.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registered")]
        Registered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2CallBaseCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2CallBaseCallStatus value)
        {
            return value switch
            {
                V2CallBaseCallStatus.Ended => "ended",
                V2CallBaseCallStatus.Error => "error",
                V2CallBaseCallStatus.NotConnected => "not_connected",
                V2CallBaseCallStatus.Ongoing => "ongoing",
                V2CallBaseCallStatus.Registered => "registered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2CallBaseCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => V2CallBaseCallStatus.Ended,
                "error" => V2CallBaseCallStatus.Error,
                "not_connected" => V2CallBaseCallStatus.NotConnected,
                "ongoing" => V2CallBaseCallStatus.Ongoing,
                "registered" => V2CallBaseCallStatus.Registered,
                _ => null,
            };
        }
    }
}