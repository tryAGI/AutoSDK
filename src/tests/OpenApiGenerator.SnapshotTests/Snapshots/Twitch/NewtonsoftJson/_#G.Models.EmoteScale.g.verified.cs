//HintName: G.Models.EmoteScale.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmoteScale
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1.0")]
        _10,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2.0")]
        _20,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3.0")]
        _30,
    }

    public static class EmoteScaleExtensions
    {
        public static string ToValueString(this EmoteScale value)
        {
            return value switch
            {
                EmoteScale._10 => "1.0",
                EmoteScale._20 => "2.0",
                EmoteScale._30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteScale ToEnum(string value)
        {
            return value switch
            {
                "1.0" => EmoteScale._10,
                "2.0" => EmoteScale._20,
                "3.0" => EmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteScale ToEnum(int value)
        {
            return value switch
            {
                0 => EmoteScale._10,
                1 => EmoteScale._20,
                2 => EmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}