//HintName: G.Models.GetLanguagesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: source
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetLanguagesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source")]
        Source,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="target")]
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesType value)
        {
            return value switch
            {
                GetLanguagesType.Source => "source",
                GetLanguagesType.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesType? ToEnum(string value)
        {
            return value switch
            {
                "source" => GetLanguagesType.Source,
                "target" => GetLanguagesType.Target,
                _ => null,
            };
        }
    }
}