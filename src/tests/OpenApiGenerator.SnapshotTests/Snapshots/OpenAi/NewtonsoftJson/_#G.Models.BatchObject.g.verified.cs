//HintName: G.Models.BatchObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `batch`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
    }

    public static class BatchObjectExtensions
    {
        public static string ToValueString(this BatchObject value)
        {
            return value switch
            {
                BatchObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BatchObject ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchObject.Batch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BatchObject ToEnum(int value)
        {
            return value switch
            {
                0 => BatchObject.Batch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}