//HintName: G.Models.AssetStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status for this asset lifecycle
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetStatus2 value)
        {
            return value switch
            {
                AssetStatus2.Created => "created",
                AssetStatus2.Done => "done",
                AssetStatus2.Error => "error",
                AssetStatus2.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => AssetStatus2.Created,
                "done" => AssetStatus2.Done,
                "error" => AssetStatus2.Error,
                "started" => AssetStatus2.Started,
                _ => null,
            };
        }
    }
}