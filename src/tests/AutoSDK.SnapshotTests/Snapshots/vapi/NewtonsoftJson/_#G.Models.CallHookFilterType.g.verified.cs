//HintName: G.Models.CallHookFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallHookFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oneOf")]
        OneOf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHookFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHookFilterType value)
        {
            return value switch
            {
                CallHookFilterType.OneOf => "oneOf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHookFilterType? ToEnum(string value)
        {
            return value switch
            {
                "oneOf" => CallHookFilterType.OneOf,
                _ => null,
            };
        }
    }
}