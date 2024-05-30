//HintName: G.Models.DoneEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DoneEventData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="[DONE]")]
        DONE,
    }

    public static class DoneEventDataExtensions
    {
        public static string ToValueString(this DoneEventData value)
        {
            return value switch
            {
                DoneEventData.DONE => "[DONE]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DoneEventData ToEnum(string value)
        {
            return value switch
            {
                "[DONE]" => DoneEventData.DONE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DoneEventData ToEnum(int value)
        {
            return value switch
            {
                0 => DoneEventData.DONE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}