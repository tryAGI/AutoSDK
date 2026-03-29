//HintName: G.Models.DataEntryVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DataEntryVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input-body")]
        InputBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataEntryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant3Type value)
        {
            return value switch
            {
                DataEntryVariant3Type.InputBody => "input-body",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "input-body" => DataEntryVariant3Type.InputBody,
                _ => null,
            };
        }
    }
}