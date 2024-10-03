//HintName: G.Models.SampleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SampleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pretrain")]
        Pretrain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="instruct")]
        Instruct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SampleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SampleType value)
        {
            return value switch
            {
                SampleType.Pretrain => "pretrain",
                SampleType.Instruct => "instruct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SampleType? ToEnum(string value)
        {
            return value switch
            {
                "pretrain" => SampleType.Pretrain,
                "instruct" => SampleType.Instruct,
                _ => null,
            };
        }
    }
}