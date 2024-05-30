//HintName: G.Models.DoneEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DoneEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
    }

    public static class DoneEventEventExtensions
    {
        public static string ToValueString(this DoneEventEvent value)
        {
            return value switch
            {
                DoneEventEvent.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DoneEventEvent ToEnum(string value)
        {
            return value switch
            {
                "done" => DoneEventEvent.Done,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DoneEventEvent ToEnum(int value)
        {
            return value switch
            {
                0 => DoneEventEvent.Done,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}