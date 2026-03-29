//HintName: G.Models.Pooling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum of possible pooling choices with pooling behaviors.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Pooling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cls")]
        Cls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last")]
        Last,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mean")]
        Mean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PoolingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Pooling value)
        {
            return value switch
            {
                Pooling.Cls => "cls",
                Pooling.Last => "last",
                Pooling.Mean => "mean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Pooling? ToEnum(string value)
        {
            return value switch
            {
                "cls" => Pooling.Cls,
                "last" => Pooling.Last,
                "mean" => Pooling.Mean,
                _ => null,
            };
        }
    }
}