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

    public static class CheermoteTiersIdExtensions
    {
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
        public static CheermoteTiersId ToEnum(int value)
        {
            return value switch
            {
                0 => CheermoteTiersId._1,
                1 => CheermoteTiersId._100,
                2 => CheermoteTiersId._500,
                3 => CheermoteTiersId._1000,
                4 => CheermoteTiersId._5000,
                5 => CheermoteTiersId._10000,
                6 => CheermoteTiersId._100000,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}