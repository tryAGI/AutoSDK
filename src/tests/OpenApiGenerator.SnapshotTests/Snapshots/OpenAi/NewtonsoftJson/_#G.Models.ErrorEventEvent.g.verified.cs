//HintName: G.Models.ErrorEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ErrorEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    public static class ErrorEventEventExtensions
    {
        public static string ToValueString(this ErrorEventEvent value)
        {
            return value switch
            {
                ErrorEventEvent.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ErrorEventEvent ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorEventEvent.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ErrorEventEvent ToEnum(int value)
        {
            return value switch
            {
                0 => ErrorEventEvent.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}