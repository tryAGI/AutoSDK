//HintName: G.Models.DoneReasonEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DoneReasonEnum
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
    public static class DoneReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoneReasonEnum value)
        {
            return value switch
            {
                DoneReasonEnum.Stop => "stop",
                DoneReasonEnum.Length => "length",
                DoneReasonEnum.Load => "load",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoneReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "stop" => DoneReasonEnum.Stop,
                "length" => DoneReasonEnum.Length,
                "load" => DoneReasonEnum.Load,
                _ => null,
            };
        }
    }
}