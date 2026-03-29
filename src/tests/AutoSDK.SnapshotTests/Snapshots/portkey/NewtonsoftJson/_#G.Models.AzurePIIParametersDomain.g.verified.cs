//HintName: G.Models.AzurePIIParametersDomain.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Domain to check against<br/>
    /// Default Value: none
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzurePIIParametersDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phi")]
        Phi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzurePIIParametersDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzurePIIParametersDomain value)
        {
            return value switch
            {
                AzurePIIParametersDomain.None => "none",
                AzurePIIParametersDomain.Phi => "phi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzurePIIParametersDomain? ToEnum(string value)
        {
            return value switch
            {
                "none" => AzurePIIParametersDomain.None,
                "phi" => AzurePIIParametersDomain.Phi,
                _ => null,
            };
        }
    }
}