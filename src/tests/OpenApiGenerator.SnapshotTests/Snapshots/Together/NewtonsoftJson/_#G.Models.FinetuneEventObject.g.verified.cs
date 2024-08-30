//HintName: G.Models.FinetuneEventObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneEventObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FinetuneEvent")]
        FinetuneEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventObject value)
        {
            return value switch
            {
                FinetuneEventObject.FinetuneEvent => "FinetuneEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventObject? ToEnum(string value)
        {
            return value switch
            {
                "FinetuneEvent" => FinetuneEventObject.FinetuneEvent,
                _ => null,
            };
        }
    }
}