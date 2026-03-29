//HintName: G.Models.SendCallRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model type for the call<br/>
    /// Default Value: base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendCallRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base")]
        Base,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="turbo")]
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendCallRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendCallRequestModel value)
        {
            return value switch
            {
                SendCallRequestModel.Base => "base",
                SendCallRequestModel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendCallRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "base" => SendCallRequestModel.Base,
                "turbo" => SendCallRequestModel.Turbo,
                _ => null,
            };
        }
    }
}