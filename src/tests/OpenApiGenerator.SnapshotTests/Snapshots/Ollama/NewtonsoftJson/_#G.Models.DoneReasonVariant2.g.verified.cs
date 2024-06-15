//HintName: G.Models.DoneReasonVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DoneReasonVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="load")]
        Load,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoneReasonVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoneReasonVariant2 value)
        {
            return value switch
            {
                DoneReasonVariant2.Stop => "stop",
                DoneReasonVariant2.Length => "length",
                DoneReasonVariant2.Load => "load",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoneReasonVariant2? ToEnum(string value)
        {
            return value switch
            {
                "stop" => DoneReasonVariant2.Stop,
                "length" => DoneReasonVariant2.Length,
                "load" => DoneReasonVariant2.Load,
                _ => null,
            };
        }
    }
}