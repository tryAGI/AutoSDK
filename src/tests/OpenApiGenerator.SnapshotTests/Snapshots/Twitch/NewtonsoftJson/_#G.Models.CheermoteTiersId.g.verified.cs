//HintName: G.Models.CheermoteTiersId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tier level. Possible tiers are:  
    ///   
    /// * 1
    /// * 100
    /// * 500
    /// * 1000
    /// * 5000
    /// * 10000
    /// * 100000
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheermoteTiersId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        _1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100")]
        _100,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="500")]
        _500,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1000")]
        _1000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5000")]
        _5000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="10000")]
        _10000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100000")]
        _100000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheermoteTiersIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheermoteTiersId value)
        {
            return value switch
            {
                CheermoteTiersId._1 => "1",
                CheermoteTiersId._100 => "100",
                CheermoteTiersId._500 => "500",
                CheermoteTiersId._1000 => "1000",
                CheermoteTiersId._5000 => "5000",
                CheermoteTiersId._10000 => "10000",
                CheermoteTiersId._100000 => "100000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheermoteTiersId ToEnum(string value)
        {
            return value switch
            {
                "1" => CheermoteTiersId._1,
                "100" => CheermoteTiersId._100,
                "500" => CheermoteTiersId._500,
                "1000" => CheermoteTiersId._1000,
                "5000" => CheermoteTiersId._5000,
                "10000" => CheermoteTiersId._10000,
                "100000" => CheermoteTiersId._100000,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}