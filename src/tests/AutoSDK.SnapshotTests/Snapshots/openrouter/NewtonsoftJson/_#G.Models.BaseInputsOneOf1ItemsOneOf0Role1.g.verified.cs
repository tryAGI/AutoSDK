//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Role1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseInputsOneOf1ItemsOneOf0Role1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0Role1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0Role1 value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0Role1.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0Role1? ToEnum(string value)
        {
            return value switch
            {
                "system" => BaseInputsOneOf1ItemsOneOf0Role1.System,
                _ => null,
            };
        }
    }
}