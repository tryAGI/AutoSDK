//HintName: G.Models.CheermoteTiersId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tier level. Possible tiers are:  <br/>
    ///   <br/>
    /// * 1<br/>
    /// * 100<br/>
    /// * 500<br/>
    /// * 1000<br/>
    /// * 5000<br/>
    /// * 10000<br/>
    /// * 100000
    /// </summary>
    public enum CheermoteTiersId
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x100,
        /// <summary>
        /// 
        /// </summary>
        x500,
        /// <summary>
        /// 
        /// </summary>
        x1000,
        /// <summary>
        /// 
        /// </summary>
        x5000,
        /// <summary>
        /// 
        /// </summary>
        x10000,
        /// <summary>
        /// 
        /// </summary>
        x100000,
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
                CheermoteTiersId.x1 => "1",
                CheermoteTiersId.x100 => "100",
                CheermoteTiersId.x500 => "500",
                CheermoteTiersId.x1000 => "1000",
                CheermoteTiersId.x5000 => "5000",
                CheermoteTiersId.x10000 => "10000",
                CheermoteTiersId.x100000 => "100000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheermoteTiersId? ToEnum(string value)
        {
            return value switch
            {
                "1" => CheermoteTiersId.x1,
                "100" => CheermoteTiersId.x100,
                "500" => CheermoteTiersId.x500,
                "1000" => CheermoteTiersId.x1000,
                "5000" => CheermoteTiersId.x5000,
                "10000" => CheermoteTiersId.x10000,
                "100000" => CheermoteTiersId.x100000,
                _ => null,
            };
        }
    }
}