//HintName: G.Models.V2WebCallResponseVariant1CallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the call. Used to distinguish between web call and phone call.<br/>
    /// Example: web_call
    /// </summary>
    public enum V2WebCallResponseVariant1CallType
    {
        /// <summary>
        /// 
        /// </summary>
        WebCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2WebCallResponseVariant1CallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2WebCallResponseVariant1CallType value)
        {
            return value switch
            {
                V2WebCallResponseVariant1CallType.WebCall => "web_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2WebCallResponseVariant1CallType? ToEnum(string value)
        {
            return value switch
            {
                "web_call" => V2WebCallResponseVariant1CallType.WebCall,
                _ => null,
            };
        }
    }
}